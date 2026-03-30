using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI.BookingUI
{
    /// <summary>
    /// 💳 PAYMENT FORM - Professional Hotel Payment Processing
    /// Displays invoice information and handles payment methods
    /// </summary>
    public partial class PaymentForm : Form
    {
        #region ==================== FIELDS ====================

        private IRentalDetailService _rentalDetailService;
        private IInvoiceService _invoiceService;

        private RentalDetail _rentalDetail;
        private Invoice _invoice;
 private int _totalAmount;
  private int _depositAmount;
        private int _remainingAmount;

        // UI Controls
     private Label lblRentalId;
        private Label lblCustomerName;
        private Label lblIdNumber;
        private Label lblInvoiceNumber;
        private DataGridView dgvRooms;
        private DataGridView dgvServices;
        private Label lblTotalRoomCost;
        private Label lblTotalServiceCost;
 private Label lblDepositPaid;
      private Label lblRemaining;
        private Label lblGrandTotal;
        private NumericUpDown nudPaymentAmount;
        private ComboBox cboPaymentMethod;
    private Button btnPay;
        private Button btnCancel;
        private Label lblQRCode;

        #endregion

        #region ==================== CONSTRUCTOR ====================

        public PaymentForm()
        {
       InitializeComponent();
 }

    public PaymentForm(
 RentalDetail rentalDetail,
      Invoice invoice,
            int totalAmount,
            int depositAmount,
            IRentalDetailService rentalDetailService,
       IInvoiceService invoiceService) : this()
    {
            _rentalDetail = rentalDetail;
            _invoice = invoice;
        _totalAmount = totalAmount;
      _depositAmount = depositAmount;
       _remainingAmount = totalAmount - depositAmount;
        _rentalDetailService = rentalDetailService;
          _invoiceService = invoiceService;
        }

        #endregion

        #region ==================== FORM LOAD ====================

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            try
   {
                SetupForm();
                CreateUI();
             PopulateData();
  }
        catch (Exception ex)
        {
          MessageBox.Show($"Lỗi khởi tạo form: {ex.Message}", "Lỗi",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }

        #endregion

        #region ==================== SETUP ====================

        private void SetupForm()
        {
            this.Text = "💳 THANH TOÁN";
            this.Width = 1400;
          this.Height = 750;
     this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
       this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.BackColor = Color.FromArgb(249, 250, 251);
        }

        #endregion

        #region ==================== UI CREATION ====================

        private void CreateUI()
   {
  // Header
  var headerPanel = CreateHeaderPanel();
            Controls.Add(headerPanel);

         // Main Layout
   var mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
          ColumnCount = 2,
       RowCount = 1,
        BackColor = Color.Transparent,
           Padding = new Padding(15)
     };
  mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
    mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));

            // Left Panel - Invoice Details
            var leftPanel = CreateLeftPanel();
     mainLayout.Controls.Add(leftPanel, 0, 0);

 // Right Panel - Payment Info
     var rightPanel = CreateRightPanel();
 mainLayout.Controls.Add(rightPanel, 1, 0);

     Controls.Add(mainLayout);

// Footer
            var footerPanel = CreateFooterPanel();
        Controls.Add(footerPanel);
        }

        private Panel CreateHeaderPanel()
        {
     var panel = new Panel
 {
          Height = 70,
      Dock = DockStyle.Top,
     BackColor = Color.FromArgb(20, 184, 166),
          Padding = new Padding(20)
   };

          var lblTitle = new Label
      {
     Text = "Vui lòng kiểm tra thông tin thanh toán trước khi thanh toán",
      Font = new Font("Segoe UI", 13, FontStyle.Bold),
        ForeColor = Color.White,
     Dock = DockStyle.Fill,
    TextAlign = ContentAlignment.MiddleLeft
            };

     panel.Controls.Add(lblTitle);
     return panel;
        }

 private Panel CreateLeftPanel()
     {
            var panel = new Panel
         {
    Dock = DockStyle.Fill,
  BackColor = Color.White,
           Padding = new Padding(15),
        AutoScroll = true,
BorderStyle = BorderStyle.FixedSingle
            };

   var layout = new TableLayoutPanel
            {
     Dock = DockStyle.Top,
        ColumnCount = 1,
     RowCount = 5,
          AutoSize = true,
Padding = new Padding(0)
            };
   layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
          layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 180));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

          // Section 1: Rental Info
            layout.Controls.Add(CreateRentalInfoPanel(), 0, 0);

            // Section 2: Rooms Table
  layout.Controls.Add(CreateRoomsPanel(), 0, 1);

            // Section 3: Services Table
            layout.Controls.Add(CreateServicesPanel(), 0, 2);

            // Section 4: Separator
  var separator = new Panel { Height = 1, BackColor = Color.FromArgb(200, 200, 200) };
            layout.Controls.Add(separator, 0, 3);

     panel.Controls.Add(layout);
            return panel;
        }

        private Panel CreateRentalInfoPanel()
        {
    var panel = new Panel
      {
        Dock = DockStyle.Top,
     Height = 120,
  BackColor = Color.FromArgb(243, 244, 246),
 BorderStyle = BorderStyle.FixedSingle,
       Padding = new Padding(10)
};

         var lblSectionTitle = new Label
 {
          Text = "DANH SÁCH PHÒNG THUÊ",
  Font = new Font("Segoe UI", 11, FontStyle.Bold),
 ForeColor = Color.FromArgb(59, 130, 246),
           AutoSize = true,
         Location = new Point(10, 5)
      };
     panel.Controls.Add(lblSectionTitle);

            int y = 30;
     AddInfoRow(panel, "Mã chi tiết:", ref lblRentalId, y); y += 25;
      AddInfoRow(panel, "Tên khách hàng:", ref lblCustomerName, y); y += 25;
            AddInfoRow(panel, "CMND/CCCD:", ref lblIdNumber, y);

   return panel;
        }

        private Panel CreateRoomsPanel()
        {
            var panel = new Panel
 {
             Dock = DockStyle.Top,
      Height = 200,
 BackColor = Color.White,
              Padding = new Padding(10),
     BorderStyle = BorderStyle.FixedSingle
    };

     var lblTitle = new Label
  {
      Text = "DANH SÁCH PHÒNG THUÊ",
 Font = new Font("Segoe UI", 11, FontStyle.Bold),
    ForeColor = Color.FromArgb(59, 130, 246),
    AutoSize = true,
     Location = new Point(10, 5)
    };
       panel.Controls.Add(lblTitle);

     dgvRooms = new DataGridView
      {
  Name = "dgvRooms",
       AutoGenerateColumns = false,
     AllowUserToAddRows = false,
         ReadOnly = true,
        BackgroundColor = Color.White,
      BorderStyle = BorderStyle.FixedSingle,
        RowHeadersVisible = false,
                Width = panel.Width - 30,
       Height = 160,
  Location = new Point(10, 35)
     };

 dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Width = 40 });
            dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TÊN PHÒNG", Width = 120 });
  dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "LOẠI HÌNH THUÊ", Width = 100 });
          dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "NGÀY THUÊ", Width = 110 });
            dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "NGÀY TRẢ", Width = 110 });
       dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "GIÁ PHÒNG", Width = 100 });

    dgvRooms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(59, 130, 246);
    dgvRooms.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
      dgvRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

   panel.Controls.Add(dgvRooms);
     return panel;
    }

        private Panel CreateServicesPanel()
        {
            var panel = new Panel
   {
        Dock = DockStyle.Top,
   Height = 180,
  BackColor = Color.White,
 Padding = new Padding(10),
 BorderStyle = BorderStyle.FixedSingle
            };

            var lblTitle = new Label
            {
         Text = "DANH SÁCH DỊCH VỤ THUÊ",
    Font = new Font("Segoe UI", 11, FontStyle.Bold),
        ForeColor = Color.FromArgb(245, 158, 11),
      AutoSize = true,
                Location = new Point(10, 5)
         };
        panel.Controls.Add(lblTitle);

          dgvServices = new DataGridView
      {
           Name = "dgvServices",
         AutoGenerateColumns = false,
     AllowUserToAddRows = false,
 ReadOnly = true,
                BackgroundColor = Color.White,
            BorderStyle = BorderStyle.FixedSingle,
                RowHeadersVisible = false,
      Width = panel.Width - 30,
        Height = 130,
              Location = new Point(10, 35)
            };

     dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Width = 40 });
   dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TÊN DỊCH VỤ", Width = 150 });
    dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "LOẠI DỊCH VỤ", Width = 100 });
            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "NGÀY SỬ DỤNG", Width = 110 });
    dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SỐ LƯỢNG", Width = 80 });
   dgvServices.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ĐƠN GIÁ", Width = 100 });

            dgvServices.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 158, 11);
            dgvServices.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvServices.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            panel.Controls.Add(dgvServices);
  return panel;
    }

        private Panel CreateRightPanel()
        {
        var panel = new Panel
            {
        Dock = DockStyle.Fill,
         BackColor = Color.White,
          Padding = new Padding(15),
      BorderStyle = BorderStyle.FixedSingle,
       Margin = new Padding(10, 0, 0, 0)
      };

   var layout = new TableLayoutPanel
            {
            Dock = DockStyle.Fill,
    ColumnCount = 1,
             RowCount = 6,
    AutoSize = false
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
     layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 150));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
   layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

        // Title
            var lblTitle = new Label
         {
                Text = "THÔNG TIN THANH TOÁN",
         Font = new Font("Segoe UI", 12, FontStyle.Bold),
ForeColor = Color.FromArgb(20, 184, 166),
   Dock = DockStyle.Fill,
     TextAlign = ContentAlignment.MiddleLeft
    };
layout.Controls.Add(lblTitle, 0, 0);

     // Customer Info
       var custPanel = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(243, 244, 246), BorderStyle = BorderStyle.FixedSingle, Padding = new Padding(10) };
  int yPos = 5;
        AddInfoLabel(custPanel, "Hộ tên khách hàng:", ref lblCustomerName, yPos); yPos += 30;
         AddInfoLabel(custPanel, "CMND/CCCD:", ref lblIdNumber, yPos); yPos += 30;
     AddInfoLabel(custPanel, "Số lần thuê trước:", new Label { Text = "1", Location = new Point(120, yPos), AutoSize = true }, yPos);
          layout.Controls.Add(custPanel, 0, 1);

            // Amount Info
            var amountPanel = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Padding = new Padding(10) };
  yPos = 5;
     AddMoneyRow(amountPanel, "Tổng tiền phòng:", ref lblTotalRoomCost, yPos); yPos += 30;
    AddMoneyRow(amountPanel, "Tổng tiền dịch vụ:", ref lblTotalServiceCost, yPos); yPos += 30;
            AddMoneyRow(amountPanel, "Tiền đặt cọc:", ref lblDepositPaid, yPos);
            layout.Controls.Add(amountPanel, 0, 2);

      // Payment Method
    var paymentPanel = new Panel { Dock = DockStyle.Fill, BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Padding = new Padding(10) };
   var lblPaymentTitle = new Label { Text = "Phương thức thanh toán:", Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(10, 10), AutoSize = true };
            paymentPanel.Controls.Add(lblPaymentTitle);

        cboPaymentMethod = new ComboBox
     {
        Location = new Point(10, 35),
  Width = 300,
        Height = 28,
             DropDownStyle = ComboBoxStyle.DropDownList
          };
        cboPaymentMethod.Items.AddRange(new string[] { "Tiền mặt", "Chuyển khoản", "Thẻ tín dụng", "Khác" });
            cboPaymentMethod.SelectedIndex = 0;
          paymentPanel.Controls.Add(cboPaymentMethod);

   var lblAmountTitle = new Label { Text = "Số tiền cần thanh toán:", Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(10, 70), AutoSize = true };
          paymentPanel.Controls.Add(lblAmountTitle);

        nudPaymentAmount = new NumericUpDown
            {
            Location = new Point(10, 95),
                Width = 300,
        Height = 28,
             Maximum = 1000000000,
         DecimalPlaces = 0,
    ThousandsSeparator = true
  };
  paymentPanel.Controls.Add(nudPaymentAmount);
 layout.Controls.Add(paymentPanel, 0, 3);

// Grand Total
      var totalPanel = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(243, 244, 246), BorderStyle = BorderStyle.FixedSingle, Padding = new Padding(10) };
    var lblGrandTotalLabel = new Label { Text = "TỔNG THÀNH TIỀN:", Font = new Font("Segoe UI", 11, FontStyle.Bold), Location = new Point(10, 10), AutoSize = true };
totalPanel.Controls.Add(lblGrandTotalLabel);
   lblGrandTotal = new Label { Text = "0 VNĐ", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.FromArgb(220, 20, 60), Location = new Point(10, 35), AutoSize = true };
    totalPanel.Controls.Add(lblGrandTotal);
layout.Controls.Add(totalPanel, 0, 4);

            // QR Code & Buttons
      var bottomPanel = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };
            lblQRCode = new Label { Text = "QR CODE", Location = new Point(10, 10), Width = 150, Height = 150, BorderStyle = BorderStyle.FixedSingle, TextAlign = ContentAlignment.MiddleCenter };
            bottomPanel.Controls.Add(lblQRCode);

    btnPay = new Button { Text = "Thanh toán", Width = 100, Height = 40, Location = new Point(170, 120), BackColor = Color.FromArgb(34, 197, 94), ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat };
       btnPay.Click += BtnPay_Click;
    bottomPanel.Controls.Add(btnPay);

  btnCancel = new Button { Text = "Hủy", Width = 100, Height = 40, Location = new Point(280, 120), BackColor = Color.FromArgb(239, 68, 68), ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat };
         btnCancel.Click += (s, e) => this.Close();
            bottomPanel.Controls.Add(btnCancel);

   layout.Controls.Add(bottomPanel, 0, 5);

      panel.Controls.Add(layout);
            return panel;
        }

        private Panel CreateFooterPanel()
        {
         var panel = new Panel
            {
         Height = 60,
      Dock = DockStyle.Bottom,
    BackColor = Color.FromArgb(243, 244, 246),
 Padding = new Padding(15),
        BorderStyle = BorderStyle.FixedSingle
       };

 var lblInfo = new Label
  {
          Text = "Vui lòng xác nhận toàn bộ thông tin thanh toán trước khi hoàn tất giao dịch",
    Font = new Font("Segoe UI", 9),
 ForeColor = Color.FromArgb(100, 100, 100),
                Dock = DockStyle.Fill,
         TextAlign = ContentAlignment.MiddleLeft
     };

        panel.Controls.Add(lblInfo);
            return panel;
        }

        #endregion

        #region ==================== DATA POPULATION ====================

        private void PopulateData()
        {
            try
   {
  if (_rentalDetail == null) return;

          // Rental Info
            lblRentalId.Text = _rentalDetail.RentalDetailId;
   lblCustomerName.Text = _rentalDetail.Customer?.Name ?? "N/A";
  lblIdNumber.Text = _rentalDetail.Customer?.IdNumber ?? "N/A";

      // Amount Info
              int roomCost = _rentalDetail.RoomRentalDetails?.Sum(r => r.RentalPrice * (int)(r.ReturnDate - r.RentalDate).TotalDays) ?? 0;
       int serviceCost = _rentalDetail.ServiceRentalDetails?.Sum(s => s.Price * s.Quantity) ?? 0;

     lblTotalRoomCost.Text = roomCost.ToString("N0") + " VNĐ";
            lblTotalServiceCost.Text = serviceCost.ToString("N0") + " VNĐ";
 lblDepositPaid.Text = _depositAmount.ToString("N0") + " VNĐ";
                lblGrandTotal.Text = _totalAmount.ToString("N0") + " VNĐ";

  nudPaymentAmount.Value = _remainingAmount;

 // Populate Grids
 PopulateRoomsGrid();
     PopulateServicesGrid();
  }
        catch (Exception ex)
 {
    MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateRoomsGrid()
   {
  if (dgvRooms == null || _rentalDetail?.RoomRentalDetails == null) return;

            dgvRooms.Rows.Clear();
int stt = 1;
 foreach (var room in _rentalDetail.RoomRentalDetails)
            {
         dgvRooms.Rows.Add(
             stt++,
            room.RoomId,
        "Theo Ngày",
          room.RentalDate.ToString("dd/MM/yyyy"),
              room.ReturnDate.ToString("dd/MM/yyyy"),
           room.RentalPrice.ToString("N0")
      );
            }
   }

        private void PopulateServicesGrid()
{
   if (dgvServices == null || _rentalDetail?.ServiceRentalDetails == null) return;

  dgvServices.Rows.Clear();
          int stt = 1;
         foreach (var service in _rentalDetail.ServiceRentalDetails)
            {
                dgvServices.Rows.Add(
             stt++,
   service.ServiceId,
           "Dịch Vụ",
        service.UsageDate.ToString("dd/MM/yyyy"),
    service.Quantity,
                service.Price.ToString("N0")
       );
            }
        }

     #endregion

        #region ==================== EVENT HANDLERS ====================

 private async void BtnPay_Click(object sender, EventArgs e)
      {
            try
    {
         if (nudPaymentAmount.Value <= 0)
     {
    MessageBox.Show("Vui lòng nhập số tiền thanh toán", "Cảnh báo",
     MessageBoxButtons.OK, MessageBoxIcon.Warning);
    return;
     }

         var result = MessageBox.Show(
         $"Xác nhận thanh toán {nudPaymentAmount.Value:N0} VNĐ bằng {cboPaymentMethod.SelectedItem}?",
           "Xác nhận thanh toán",
               MessageBoxButtons.YesNo,
     MessageBoxIcon.Question);

     if (result == DialogResult.Yes)
            {
        // Update invoice payment method
             if (_invoice != null && _invoiceService != null)
      {
       _invoice.PaymentMethod = cboPaymentMethod.SelectedIndex;
 _invoice.PaymentDate = DateTime.Now;
            await _invoiceService.UpdateInvoiceAsync(_invoice);
               }

    MessageBox.Show(
     "✓ Thanh toán thành công!",
        "Thành công",
      MessageBoxButtons.OK,
    MessageBoxIcon.Information);

    this.DialogResult = DialogResult.OK;
       this.Close();
    }
            }
       catch (Exception ex)
      {
         MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

 #region ==================== HELPERS ====================

        private void AddInfoRow(Panel panel, string label, ref Label valueControl, int yPos)
        {
            var lbl = new Label
            {
      Text = label,
  Font = new Font("Segoe UI", 9),
           Location = new Point(10, yPos),
      AutoSize = true
  };
      panel.Controls.Add(lbl);

            valueControl = new Label
    {
      Text = "N/A",
          Font = new Font("Segoe UI", 9, FontStyle.Bold),
         Location = new Point(140, yPos),
             AutoSize = true
            };
   panel.Controls.Add(valueControl);
        }

        private void AddInfoLabel(Panel panel, string label, ref Label valueControl, int yPos)
    {
            var lbl = new Label
  {
     Text = label,
   Font = new Font("Segoe UI", 9),
        Location = new Point(10, yPos),
    AutoSize = true
  };
    panel.Controls.Add(lbl);

  valueControl = new Label
      {
             Text = "N/A",
 Font = new Font("Segoe UI", 9, FontStyle.Bold),
             Location = new Point(140, yPos),
      AutoSize = true
            };
            panel.Controls.Add(valueControl);
        }

private void AddInfoLabel(Panel panel, string label, Label valueControl, int yPos)
        {
        var lbl = new Label
            {
  Text = label,
                Font = new Font("Segoe UI", 9),
              Location = new Point(10, yPos),
     AutoSize = true
            };
            panel.Controls.Add(lbl);
      panel.Controls.Add(valueControl);
        }

private void AddMoneyRow(Panel panel, string label, ref Label valueControl, int yPos)
        {
    var lbl = new Label
        {
     Text = label,
       Font = new Font("Segoe UI", 9),
        Location = new Point(10, yPos),
AutoSize = true
    };
            panel.Controls.Add(lbl);

      valueControl = new Label
            {
        Text = "0 VNĐ",
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
       ForeColor = Color.FromArgb(220, 20, 60),
  Location = new Point(140, yPos),
        AutoSize = true
      };
          panel.Controls.Add(valueControl);
 }

        #endregion
    }
}
