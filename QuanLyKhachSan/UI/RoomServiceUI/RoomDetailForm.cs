using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.UI.Room_Service
{
    public partial class RoomDetailForm : Form
    {
        private readonly HotelDbContext _dbContext;
        private Room _currentRoom;
        private List<Amenity> _allAmenities;
        private Dictionary<string, int> _selectedAmenities = new();

        public RoomDetailForm()
        {
            InitializeComponent();
        }

        public RoomDetailForm(string roomId, HotelDbContext dbContext) : this()
        {
            _dbContext = dbContext;
            LoadRoomData(roomId);
            InitializeEventHandlers();
        }

        private void LoadRoomData(string roomId)
        {
            try
            {
                if (_dbContext == null) return;

                _currentRoom = _dbContext.Rooms.FirstOrDefault(r => r.RoomId == roomId);
                if (_currentRoom == null)
                {
                    MessageBox.Show("Phòng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                _allAmenities = _dbContext.Amenities.Where(a => a.IsDeleted == 0).ToList();

                // Display room info
                DisplayRoomInfo();

                // Load room amenities
                LoadRoomAmenities();

                // Load all amenities
                BindAllAmenities(_allAmenities);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayRoomInfo()
        {
            txtRoomCode.Text = _currentRoom.RoomId;
            txtRoomName.Text = _currentRoom.Name;

            if (_currentRoom.RoomType == 2)
                rbVip.Checked = true;
            else
                rbNormal.Checked = true;

            switch (_currentRoom.RoomTypeDetails)
            {
                case 1: rbSingle.Checked = true; break;
                case 2: rbDouble.Checked = true; break;
                case 3: rbFamily.Checked = true; break;
                default: rbSingle.Checked = true; break;
            }

            txtPrice.Text = _currentRoom.Price.ToString();
            txtStatus.Text = GetStatusDisplay(_currentRoom.Status);
            cbCurrentState.SelectedIndex = _currentRoom.CurrentCondition;
        }

        private void LoadRoomAmenities()
        {
            _selectedAmenities.Clear();
            var roomAmenities = _dbContext.RoomAmenities
           .Where(ra => ra.RoomId == _currentRoom.RoomId)
              .ToList();

            foreach (var ra in roomAmenities)
            {
                _selectedAmenities[ra.AmenityId] = ra.Quantity;
            }

            BindRoomAmenities(_selectedAmenities);
        }

        private void BindAllAmenities(List<Amenity> amenities)
        {
            if (dgvAllAmenities == null) return;

            dgvAllAmenities.Rows.Clear();
            int stt = 1;
            foreach (var amenity in amenities)
            {
                dgvAllAmenities.Rows.Add(stt++, amenity.AmenityId, amenity.Name);
            }
        }

        private void BindRoomAmenities(Dictionary<string, int> amenities)
        {
            if (dgvRoomAmenities == null) return;

            dgvRoomAmenities.Rows.Clear();
            int stt = 1;
            var search = txtSearchRoomAmenity.Text.Trim().ToLower();

            foreach (var item in amenities)
            {
                var amenity = _allAmenities?.FirstOrDefault(a => a.AmenityId == item.Key);
                if (amenity != null)
                {
                    if (amenity.AmenityId.ToLower().Contains(search) ||
                  amenity.Name.ToLower().Contains(search))
                    {
                        dgvRoomAmenities.Rows.Add(stt++, amenity.AmenityId, amenity.Name, item.Value);
                    }
                }
            }
        }

        private void InitializeEventHandlers()
        {
            btnSaveRoom.Click += BtnSaveRoom_Click;
            btnDeleteRoom.Click += BtnDeleteRoom_Click;
            btnAddAmenity.Click += BtnAddAmenity_Click;
            btnEditAmenity.Click += BtnEditAmenity_Click;
            btnDeleteAmenity.Click += BtnDeleteAmenity_Click;
            txtSearchAmenity.TextChanged += (s, e) => FilterAmenities();
            txtSearchRoomAmenity.TextChanged += (s, e) => BindRoomAmenities(_selectedAmenities);
            dgvRoomAmenities.SelectionChanged += (s, e) => UpdateAmenityQuantity();
            btnNew.Click += (s, e) => ResetForm();
        }

        private void FilterAmenities()
        {
            if (_allAmenities == null) return;

            var search = txtSearchAmenity.Text.Trim().ToLower();
            var filtered = _allAmenities.Where(a =>
         a.AmenityId.ToLower().Contains(search) ||
     a.Name.ToLower().Contains(search)).ToList();

            BindAllAmenities(filtered);
        }

        private void BtnAddAmenity_Click(object sender, EventArgs e)
        {
            if (dgvAllAmenities.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tiện ích cần thêm", "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var amenityId = dgvAllAmenities.SelectedRows[0].Cells[1].Value?.ToString();
            if (string.IsNullOrEmpty(amenityId)) return;

            if (_selectedAmenities.ContainsKey(amenityId))
            {
                MessageBox.Show("Tiện ích này đã được thêm", "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedAmenities[amenityId] = (int)numQuantity.Value;
            numQuantity.Value = 1;
            BindRoomAmenities(_selectedAmenities);
        }

        private void BtnEditAmenity_Click(object sender, EventArgs e)
        {
            if (dgvRoomAmenities.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tiện ích cần sửa", "Thông báo",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (numRoomAmenityQuantity.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0", "Thông báo",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var amenityId = dgvRoomAmenities.SelectedRows[0].Cells[1].Value?.ToString();
            if (!string.IsNullOrEmpty(amenityId))
            {
                _selectedAmenities[amenityId] = (int)numRoomAmenityQuantity.Value;
                BindRoomAmenities(_selectedAmenities);
            }
        }

        private void BtnDeleteAmenity_Click(object sender, EventArgs e)
        {
            if (dgvRoomAmenities.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tiện ích cần xóa", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc muốn xóa tiện ích này?", "Xác nhận",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var amenityId = dgvRoomAmenities.SelectedRows[0].Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(amenityId))
                {
                    _selectedAmenities.Remove(amenityId);
                    BindRoomAmenities(_selectedAmenities);
                }
            }
        }

        private void UpdateAmenityQuantity()
        {
            if (dgvRoomAmenities.SelectedRows.Count > 0)
            {
                var amenityId = dgvRoomAmenities.SelectedRows[0].Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(amenityId) && _selectedAmenities.ContainsKey(amenityId))
                {
                    numRoomAmenityQuantity.Value = _selectedAmenities[amenityId];
                }
            }
        }

        private void BtnSaveRoom_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                _currentRoom.Name = txtRoomName.Text.Trim();
                _currentRoom.RoomType = rbVip.Checked ? 2 : 1;
                _currentRoom.RoomTypeDetails = GetRoomTypeDetails();
                _currentRoom.Price = int.Parse(txtPrice.Text.Trim());
                _currentRoom.CurrentCondition = cbCurrentState.SelectedIndex;

                _dbContext.Rooms.Update(_currentRoom);

                // Remove old amenities
                var oldAmenities = _dbContext.RoomAmenities
       .Where(ra => ra.RoomId == _currentRoom.RoomId)
          .ToList();
                foreach (var ra in oldAmenities)
                {
                    _dbContext.RoomAmenities.Remove(ra);
                }

                // Add new amenities
                foreach (var amenity in _selectedAmenities)
                {
                    var roomAmenity = new RoomAmenity
                    {
                        RoomId = _currentRoom.RoomId,
                        AmenityId = amenity.Key,
                        Quantity = amenity.Value
                    };
                    _dbContext.RoomAmenities.Add(roomAmenity);
                }

                _dbContext.SaveChanges();
                MessageBox.Show("Cập nhật phòng thành công!", "Thành công",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteRoom_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Xác nhận",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                _currentRoom.IsDeleted = 1;
                _dbContext.Rooms.Update(_currentRoom);
                _dbContext.SaveChanges();

                MessageBox.Show("Xóa phòng thành công!", "Thành công",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Thông báo",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtPrice.Text.Trim(), out var price) || price < 0)
            {
                MessageBox.Show("Vui lòng nhập giá phòng hợp lệ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private int GetRoomTypeDetails()
        {
            if (rbSingle.Checked) return 1;
            if (rbDouble.Checked) return 2;
            if (rbFamily.Checked) return 3;
            return 1;
        }

        private string GetStatusDisplay(int status)
        {
            return status switch
            {
                0 => "Trống",
                1 => "Đã có khách",
                2 => "Đang dọn dẹp",
                3 => "Đang bảo trì"
            };
        }

        private void ResetForm()
        {
            LoadRoomData(_currentRoom.RoomId);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
