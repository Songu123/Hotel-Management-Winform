using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI.CustomerUI
{
    public partial class UpdateCustomerForm : Form
    {
        private readonly ICustomerService _customerService;
        private Customer _currentCustomer;

        public UpdateCustomerForm(ICustomerService customerService, Customer customer)
        {
            InitializeComponent();
            _customerService = customerService;
            _currentCustomer = customer ?? throw new ArgumentNullException(nameof(customer));
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCustomerData();
                AttachEventHandlers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomerData()
        {
            if (_currentCustomer == null) return;

            // Hiển thị mã khách hàng (không cho sửa)
            textBox1.Text = _currentCustomer.CustomerId;
            textBox1.ReadOnly = true;

            // Hiển thị thông tin khách hàng
            txtHoTen.Text = _currentCustomer.Name;
            txtCMND.Text = _currentCustomer.IdNumber;
            dtpNgaySinh.Value = _currentCustomer.DateOfBirth;
            txtSDT.Text = _currentCustomer.PhoneNumber;

            // Giới tính
            if (_currentCustomer.Gender == 1)
                rbNam.Checked = true;
            else
                rbNu.Checked = true;

            // Địa chỉ
            ParseAndSetAddress(_currentCustomer.Address);

            // Quốc tịch
            txtQuocTich.Text = _currentCustomer.Nationality;
        }

        private void ParseAndSetAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
                return;

            // Giả định định dạng: "Đường, Phường/Thôn, Quận/Huyện, Tỉnh/Thành"
            // Bạn có thể điều chỉnh tùy theo cách lưu trữ thực tế
            var parts = address.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length > 0)
                txtDuong.Text = parts[0].Trim();
            if (parts.Length > 1)
                txtPhuongThon.Text = parts[1].Trim();
            if (parts.Length > 2)
                txtQuanHuyen.Text = parts[2].Trim();
            if (parts.Length > 3)
                txtTinhThanh.Text = parts[3].Trim();
        }

        private void AttachEventHandlers()
        {
            btnLuuThayDoi.Click += BtnLuuThayDoi_Click;
            btnClose.Click += BtnClose_Click;
        }

        private async void BtnLuuThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Tên khách hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return;
                }

                // Kiểm tra số điện thoại hợp lệ
                if (!IsValidPhoneNumber(txtSDT.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return;
                }

                // Cập nhật dữ liệu
                _currentCustomer.Name = txtHoTen.Text.Trim();
                _currentCustomer.IdNumber = txtCMND.Text.Trim();
                _currentCustomer.PhoneNumber = txtSDT.Text.Trim();
                _currentCustomer.DateOfBirth = dtpNgaySinh.Value;
                _currentCustomer.Gender = rbNam.Checked ? 1 : 0;
                _currentCustomer.Address = BuildAddress();
                _currentCustomer.Nationality = txtQuocTich.Text.Trim();

                // Gọi service để cập nhật
                bool result = await _customerService.UpdateCustomerAsync(_currentCustomer);

                if (result)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuildAddress()
        {
            var parts = new List<string>();

            if (!string.IsNullOrWhiteSpace(txtDuong.Text))
                parts.Add(txtDuong.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtPhuongThon.Text))
                parts.Add(txtPhuongThon.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtQuanHuyen.Text))
                parts.Add(txtQuanHuyen.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtTinhThanh.Text))
                parts.Add(txtTinhThanh.Text.Trim());

            return string.Join(", ", parts);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra độ dài và chỉ chứa chữ số hoặc dấu ngoặc, dấu gạch ngang
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Độ dài từ 10-15 ký tự
            if (phoneNumber.Length < 10 || phoneNumber.Length > 15)
                return false;

            // Kiểm tra chỉ chứa chữ số hoặc các ký tự hợp lệ
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^[\d\s\-\+\(\)]+$");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
