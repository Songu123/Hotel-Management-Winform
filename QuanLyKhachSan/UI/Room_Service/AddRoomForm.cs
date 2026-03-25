using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.UI.Room_Service
{
    public partial class AddRoomForm : Form
    {
        private readonly HotelDbContext _dbContext;
        private List<Amenity> _allAmenities;
        private Dictionary<string, int> _selectedAmenities = new();

        public AddRoomForm()
        {
            InitializeComponent();
        }

        public AddRoomForm(HotelDbContext dbContext) : this()
        {
            _dbContext = dbContext;
            InitializeData();
        }

        private void InitializeData()
        {
            try
            {
                if (_dbContext == null) return;

                // Load all amenities
                _allAmenities = _dbContext.Amenities.Where(a => a.IsDeleted == 0).ToList();
                BindAmenityData(_allAmenities);

                // Set default values
                cboHienTrang.SelectedIndex = 0;
                rbPhongVip.Checked = true;
                rbPhongDon.Checked = true;

                // Wire up events
                btnThemPhong.Click += BtnThemPhong_Click;
                btnDong.Click += (s, e) => Close();
                btnLamMoi.Click += (s, e) => ResetForm();
                btnThemTienIch.Click += BtnThemTienIch_Click;
                btnSuaTienIch.Click += BtnSuaTienIch_Click;
                btnXoaTienIch.Click += BtnXoaTienIch_Click;
                txtTimTienIch.TextChanged += (s, e) => FilterAmenity();
                txtTimTienIchPhong.TextChanged += (s, e) => FilterRoomAmenity();
                dgvTienIchPhong.SelectionChanged += (s, e) => UpdateEditMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindAmenityData(List<Amenity> amenities)
        {
            if (dgvTienIchKhachSan == null) return;

            dgvTienIchKhachSan.Rows.Clear();
            int stt = 1;
            foreach (var amenity in amenities)
            {
                dgvTienIchKhachSan.Rows.Add(stt++, amenity.AmenityId, amenity.Name);
            }
        }

        private void FilterAmenity()
        {
            if (_allAmenities == null) return;

            var search = txtTimTienIch.Text.Trim().ToLower();
            var filtered = _allAmenities.Where(a =>
                a.AmenityId.ToLower().Contains(search) ||
                a.Name.ToLower().Contains(search)).ToList();

            BindAmenityData(filtered);
        }

        private void FilterRoomAmenity()
        {
            BindRoomAmenityData(_selectedAmenities);
        }

        private void BtnThemTienIch_Click(object sender, EventArgs e)
        {
            if (dgvTienIchKhachSan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tiện ích cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nudSoLuong1.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var amenityId = dgvTienIchKhachSan.SelectedRows[0].Cells[1].Value?.ToString();
            if (string.IsNullOrEmpty(amenityId)) return;

            if (_selectedAmenities.ContainsKey(amenityId))
            {
                MessageBox.Show("Tiện ích này đã được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedAmenities[amenityId] = (int)nudSoLuong1.Value;
            nudSoLuong1.Value = 1;
            BindRoomAmenityData(_selectedAmenities);
        }

        private void BtnSuaTienIch_Click(object sender, EventArgs e)
        {
            if (dgvTienIchPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tiện ích cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nudSoLuong2.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var amenityId = dgvTienIchPhong.SelectedRows[0].Cells[1].Value?.ToString();
            if (!string.IsNullOrEmpty(amenityId))
            {
                _selectedAmenities[amenityId] = (int)nudSoLuong2.Value;
                BindRoomAmenityData(_selectedAmenities);
            }
        }

        private void BtnXoaTienIch_Click(object sender, EventArgs e)
        {
            if (dgvTienIchPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tiện ích cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var amenityId = dgvTienIchPhong.SelectedRows[0].Cells[1].Value?.ToString();
            if (!string.IsNullOrEmpty(amenityId))
            {
                _selectedAmenities.Remove(amenityId);
                BindRoomAmenityData(_selectedAmenities);
            }
        }

        private void UpdateEditMode()
        {
            if (dgvTienIchPhong.SelectedRows.Count > 0)
            {
                var amenityId = dgvTienIchPhong.SelectedRows[0].Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(amenityId) && _selectedAmenities.ContainsKey(amenityId))
                {
                    nudSoLuong2.Value = _selectedAmenities[amenityId];
                }
            }
        }

        private void BindRoomAmenityData(Dictionary<string, int> amenities)
        {
            if (dgvTienIchPhong == null) return;

            dgvTienIchPhong.Rows.Clear();
            int stt = 1;
            var search = txtTimTienIchPhong.Text.Trim().ToLower();

            foreach (var item in amenities)
            {
                var amenity = _allAmenities?.FirstOrDefault(a => a.AmenityId == item.Key);
                if (amenity != null)
                {
                    if (amenity.AmenityId.ToLower().Contains(search) || amenity.Name.ToLower().Contains(search))
                    {
                        dgvTienIchPhong.Rows.Add(stt++, amenity.AmenityId, amenity.Name, item.Value);
                    }
                }
            }
        }

        private void BtnThemPhong_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                var room = new Room
                {
                    RoomId = txtMaPhong.Text.Trim(),
                    Name = txtTenPhong.Text.Trim(),
                    RoomType = rbPhongVip.Checked ? 2 : 1,
                    RoomTypeDetails = GetRoomTypeDetails(),
                    Price = int.Parse(txtGiaPhong.Text.Trim()),
                    Status = 1, // Trống
                    CurrentCondition = cboHienTrang.SelectedIndex,
                    IsDeleted = 0
                };

                // Check if room already exists
                if (_dbContext.Rooms.Any(r => r.RoomId == room.RoomId))
                {
                    MessageBox.Show("Mã phòng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _dbContext.Rooms.Add(room);
                _dbContext.SaveChanges();

                // Add amenities
                foreach (var amenity in _selectedAmenities)
                {
                    var roomAmenity = new RoomAmenity
                    {
                        RoomId = room.RoomId,
                        AmenityId = amenity.Key,
                        Quantity = amenity.Value
                    };
                    _dbContext.RoomAmenities.Add(roomAmenity);
                }

                _dbContext.SaveChanges();
                MessageBox.Show("Thêm phòng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtGiaPhong.Text.Trim(), out var price) || price < 0)
            {
                MessageBox.Show("Vui lòng nhập giá phòng hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private int GetRoomTypeDetails()
        {
            if (rbPhongDon.Checked) return 1;
            if (rbPhongDoi.Checked) return 2;
            if (rbPhongGia.Checked) return 3;
            return 1;
        }

        private void ResetForm()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtGiaPhong.Clear();
            cboHienTrang.SelectedIndex = 0;
            rbPhongVip.Checked = true;
            rbPhongDon.Checked = true;
            _selectedAmenities.Clear();
            nudSoLuong1.Value = 1;
            nudSoLuong2.Value = 1;
            BindAmenityData(_allAmenities);
            dgvTienIchPhong.Rows.Clear();
        }
    }
}
