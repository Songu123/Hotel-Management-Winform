using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI.Service
{
    /// <summary>
    /// 🛎️ ADD SERVICE FORM
    /// </summary>
    public class AddServiceForm : Form
    {
        private readonly IServiceService _serviceService;
        private TextBox txtServiceId;
        private TextBox txtName;
    private ComboBox cboType;
        private NumericUpDown nudPrice;
        private TextBox txtImage;
        private Button btnSave;
        private Button btnCancel;

        public AddServiceForm(IServiceService serviceService)
        {
        _serviceService = serviceService ?? throw new ArgumentNullException(nameof(serviceService));
        InitializeUI();
        }

        private void InitializeUI()
     {
     this.Text = "➕ Thêm Dịch Vụ Mới";
this.Width = 500;
            this.Height = 450;
       this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
this.MaximizeBox = false;
            this.MinimizeBox = false;
        this.BackColor = Color.FromArgb(240, 241, 245);

     int yPos = 20;
            int labelWidth = 120;

            // Mã Dịch Vụ
            var lblServiceId = new Label { Text = "Mã Dịch Vụ:", Location = new Point(20, yPos), Width = labelWidth, AutoSize = false };
         this.Controls.Add(lblServiceId);
            txtServiceId = new TextBox { Location = new Point(150, yPos), Width = 300, Height = 28, BorderStyle = BorderStyle.FixedSingle };
   this.Controls.Add(txtServiceId);

          yPos += 45;

       // Tên Dịch Vụ
 var lblName = new Label { Text = "Tên Dịch Vụ:", Location = new Point(20, yPos), Width = labelWidth, AutoSize = false };
    this.Controls.Add(lblName);
            txtName = new TextBox { Location = new Point(150, yPos), Width = 300, Height = 28, BorderStyle = BorderStyle.FixedSingle };
      this.Controls.Add(txtName);

 yPos += 45;

            // Loại Dịch Vụ
            var lblType = new Label { Text = "Loại Dịch Vụ:", Location = new Point(20, yPos), Width = labelWidth, AutoSize = false };
 this.Controls.Add(lblType);
            cboType = new ComboBox { Location = new Point(150, yPos), Width = 300, Height = 28, DropDownStyle = ComboBoxStyle.DropDownList };
            cboType.Items.AddRange(new[] { "1 - Phòng Ăn", "2 - Giặt Ủi", "3 - SPA/Massage", "4 - Đưa Đón", "5 - Khác" });
     cboType.SelectedIndex = 0;
            this.Controls.Add(cboType);

       yPos += 45;

          // Giá
   var lblPrice = new Label { Text = "Giá (VNĐ):", Location = new Point(20, yPos), Width = labelWidth, AutoSize = false };
   this.Controls.Add(lblPrice);
         nudPrice = new NumericUpDown { Location = new Point(150, yPos), Width = 300, Height = 28, Maximum = 100000000, Minimum = 0 };
  this.Controls.Add(nudPrice);

            yPos += 45;

     // Hình Ảnh
            var lblImage = new Label { Text = "Hình Ảnh:", Location = new Point(20, yPos), Width = labelWidth, AutoSize = false };
this.Controls.Add(lblImage);
            txtImage = new TextBox { Location = new Point(150, yPos), Width = 300, Height = 28, BorderStyle = BorderStyle.FixedSingle };
    this.Controls.Add(txtImage);

            yPos += 60;

  // Buttons
      btnSave = new Button
        {
     Text = "💾 Lưu",
    Location = new Point(150, yPos),
        Width = 140,
    Height = 40,
       BackColor = Color.FromArgb(34, 197, 94),
                ForeColor = Color.White,
       Font = new Font("Segoe UI", 10, FontStyle.Bold),
              FlatStyle = FlatStyle.Flat
  };
        btnSave.Click += BtnSave_Click;
    this.Controls.Add(btnSave);

            btnCancel = new Button
     {
        Text = "❌ Hủy",
          Location = new Point(310, yPos),
        Width = 140,
      Height = 40,
            BackColor = Color.FromArgb(107, 114, 128),
          ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
    FlatStyle = FlatStyle.Flat
};
            btnCancel.Click += (s, e) => this.Close();
 this.Controls.Add(btnCancel);
   }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
       try
{
     // Validate input
                if (string.IsNullOrWhiteSpace(txtServiceId.Text))
  {
              MessageBox.Show("Vui lòng nhập mã dịch vụ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
  return;
}

   if (string.IsNullOrWhiteSpace(txtName.Text))
      {
      MessageBox.Show("Vui lòng nhập tên dịch vụ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
return;
              }

           if (nudPrice.Value <= 0)
    {
           MessageBox.Show("Vui lòng nhập giá hợp lệ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
          }

              var service = new Models.Service
         {
  ServiceId = txtServiceId.Text.Trim(),
   Name = txtName.Text.Trim(),
          Type = cboType.SelectedItem.ToString().Substring(0, 1),
 Price = (int)nudPrice.Value,
      Image = txtImage.Text.Trim(),
    IsDeleted = 0
   };

                var result = await _serviceService.CreateServiceAsync(service);
      if (result != null)
         {
    MessageBox.Show("Thêm dịch vụ thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
          this.DialogResult = DialogResult.OK;
          this.Close();
                }
    else
      {
                  MessageBox.Show("Thêm dịch vụ thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
            }
            catch (Exception ex)
            {
     MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
      }
    }
}
