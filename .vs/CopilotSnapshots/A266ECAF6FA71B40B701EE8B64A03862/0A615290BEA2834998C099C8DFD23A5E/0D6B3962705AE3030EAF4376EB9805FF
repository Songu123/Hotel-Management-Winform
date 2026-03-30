using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI.BookingUI
{
    /// <summary>
    /// 🍔 Dialog để thêm dịch vụ vào đơn đặt phòng
    /// - Chọn dịch vụ
    /// - Nhập số lượng
    /// - Xem giá dịch vụ
    /// </summary>
    public class AddServiceDialog : Form
    {
        #region ==================== FIELDS ====================

    // Services interface
  private IServiceService _serviceService;

    // Public properties
        public string SelectedServiceId { get; set; } = string.Empty;
 public int Quantity { get; set; } = 1;
   public int ServicePrice { get; set; } = 0;
     public DateTime UsageDate { get; set; } = DateTime.Now;

// UI Controls
        private ComboBox cboService;
        private NumericUpDown numQuantity;
        private Label lblPrice;
  private Label lblTotal;
     private DateTimePicker dtpUsageDate;
     private Button btnAdd;
  private Button btnCancel;

     #endregion

   #region ==================== CONSTRUCTOR ====================

    public AddServiceDialog(IServiceService serviceService)
        {
  _serviceService = serviceService ?? throw new ArgumentNullException(nameof(serviceService));

    InitializeComponent();
     SetupForm();
        }

        private void InitializeComponent()
        {
      // Required for designer
        }

        #endregion

  #region ==================== SETUP ====================

        private void SetupForm()
        {
            this.Text = "➕ Thêm Dịch Vụ";
            this.Width = 450;
      this.Height = 350;
        this.StartPosition = FormStartPosition.CenterParent;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.BackColor = Color.FromArgb(249, 250, 251);
            this.Font = new Font("Segoe UI", 10);

 CreateControls();
            LoadServices();
        }

      private void CreateControls()
        {
     // Title
   var lblTitle = new Label
         {
    Text = "Chọn Dịch Vụ",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
        ForeColor = Color.FromArgb(245, 158, 11),
     Location = new Point(20, 20),
  AutoSize = true
     };
 this.Controls.Add(lblTitle);

        // Service selector
      cboService = new ComboBox
          {
    Location = new Point(20, 50),
       Width = 400,
     DropDownStyle = ComboBoxStyle.DropDownList,
     Font = new Font("Segoe UI", 10)
     };
       cboService.SelectedIndexChanged += CboService_SelectedIndexChanged;
            this.Controls.Add(cboService);

      // Usage date
        var lblUsageDate = new Label
   {
           Text = "Ngày Sử Dụng:",
    Font = new Font("Segoe UI", 9),
          Location = new Point(20, 90),
     AutoSize = true
            };
      this.Controls.Add(lblUsageDate);

   dtpUsageDate = new DateTimePicker
            {
       Location = new Point(130, 85),
         Width = 290,
                Value = DateTime.Now,
                Format = DateTimePickerFormat.Short
        };
            dtpUsageDate.ValueChanged += (s, e) => UsageDate = dtpUsageDate.Value;
 this.Controls.Add(dtpUsageDate);

            // Quantity
var lblQuantity = new Label
            {
        Text = "Số Lượng:",
      Font = new Font("Segoe UI", 9),
       Location = new Point(20, 130),
 AutoSize = true
            };
            this.Controls.Add(lblQuantity);

 numQuantity = new NumericUpDown
       {
    Location = new Point(130, 125),
  Width = 100,
  Minimum = 1,
         Maximum = 100,
 Value = 1
      };
            numQuantity.ValueChanged += NumQuantity_ValueChanged;
            this.Controls.Add(numQuantity);

         // Info panel
    var panelInfo = new Panel
      {
                Location = new Point(20, 170),
    Width = 400,
   Height = 80,
       BackColor = Color.White,
         BorderStyle = BorderStyle.FixedSingle
    };

            // Price
            var lblPriceLabel = new Label
    {
   Text = "Giá Dịch Vụ:",
 Font = new Font("Segoe UI", 9),
      Location = new Point(10, 10),
       AutoSize = true
};
         panelInfo.Controls.Add(lblPriceLabel);

      lblPrice = new Label
       {
   Text = "0 VNĐ",
     Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(150, 10),
    AutoSize = true
};
     panelInfo.Controls.Add(lblPrice);

            // Total
    var lblTotalLabel = new Label
            {
      Text = "Tổng Cộng:",
       Font = new Font("Segoe UI", 9, FontStyle.Bold),
           ForeColor = Color.FromArgb(220, 20, 60),
    Location = new Point(10, 45),
           AutoSize = true
     };
     panelInfo.Controls.Add(lblTotalLabel);

    lblTotal = new Label
            {
     Text = "0 VNĐ",
      Font = new Font("Segoe UI", 11, FontStyle.Bold),
      ForeColor = Color.FromArgb(220, 20, 60),
          Location = new Point(150, 43),
              AutoSize = true
        };
        panelInfo.Controls.Add(lblTotal);

       this.Controls.Add(panelInfo);

       // Buttons
       btnAdd = new Button
   {
Text = "✓ Thêm",
       Width = 100,
Height = 35,
      Location = new Point(150, 270),
   BackColor = Color.FromArgb(245, 158, 11),
      ForeColor = Color.White,
      Font = new Font("Segoe UI", 10, FontStyle.Bold),
         FlatStyle = FlatStyle.Flat
      };
btnAdd.Click += BtnAdd_Click;
       this.Controls.Add(btnAdd);

        btnCancel = new Button
  {
              Text = "✕ Hủy",
      Width = 100,
   Height = 35,
Location = new Point(260, 270),
   BackColor = Color.FromArgb(107, 114, 128),
        ForeColor = Color.White,
           Font = new Font("Segoe UI", 10, FontStyle.Bold),
        FlatStyle = FlatStyle.Flat,
    DialogResult = DialogResult.Cancel
         };
   this.Controls.Add(btnCancel);

            this.CancelButton = btnCancel;
        }

        #endregion

        #region ==================== METHODS ====================

        private async void LoadServices()
  {
        try
  {
  var services = await _serviceService.GetAllServicesAsync();
         var serviceList = services.ToList();

   cboService.DataSource = serviceList.Select(s => new
     {
     DisplayText = $"{s.ServiceId} - {s.Name} ({s.Type})",
           s.ServiceId,
     s.Price
                }).ToList();

          cboService.DisplayMember = "DisplayText";
     cboService.ValueMember = "ServiceId";
            }
            catch (Exception ex)
     {
      MessageBox.Show($"Lỗi tải danh sách dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboService_SelectedIndexChanged(object sender, EventArgs e)
  {
      if (cboService.SelectedItem is not null)
            {
       var selectedService = cboService.SelectedItem;
   var servicePrice = (int)selectedService.GetType().GetProperty("Price").GetValue(selectedService);
      var serviceId = (string)selectedService.GetType().GetProperty("ServiceId").GetValue(selectedService);

         SelectedServiceId = serviceId;
                ServicePrice = servicePrice;
                UpdateCalculation();
            }
        }

 private void NumQuantity_ValueChanged(object sender, EventArgs e)
        {
        Quantity = (int)numQuantity.Value;
        UpdateCalculation();
        }

        private void UpdateCalculation()
        {
      int total = ServicePrice * Quantity;

         lblPrice.Text = ServicePrice.ToString("N0") + " VNĐ";
  lblTotal.Text = total.ToString("N0") + " VNĐ";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
   {
            if (string.IsNullOrEmpty(SelectedServiceId))
         {
    MessageBox.Show("Vui lòng chọn dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
            }

      if (Quantity < 1)
            {
 MessageBox.Show("Vui lòng nhập số lượng hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
     }

            this.DialogResult = DialogResult.OK;
       this.Close();
    }

        #endregion
    }
}
