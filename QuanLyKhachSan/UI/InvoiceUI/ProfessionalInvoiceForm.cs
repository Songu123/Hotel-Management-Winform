using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.UI.InvoiceUI
{
    /// <summary>
 /// 🧾 PROFESSIONAL INVOICE FORM - Mẫu Hoá Đơn Chuyên Nghiệp
    /// </summary>
    public class ProfessionalInvoiceForm : Form
    {
        private readonly Invoice _invoice;
    private readonly RentalDetail _rentalDetail;
        private readonly IRentalDetailService _rentalDetailService;
 private readonly IRoomRentalDetailService _roomRentalDetailService;
        private readonly IEmployeeService _employeeService;
        private readonly HotelDbContext _dbContext;

        private RichTextBox rtbInvoice;

        public ProfessionalInvoiceForm(
    Invoice invoice,
            RentalDetail rentalDetail,
            IRentalDetailService rentalDetailService,
       IRoomRentalDetailService roomRentalDetailService,
     IEmployeeService employeeService,
        HotelDbContext dbContext)
 {
            _invoice = invoice;
            _rentalDetail = rentalDetail;
            _rentalDetailService = rentalDetailService;
     _roomRentalDetailService = roomRentalDetailService;
         _employeeService = employeeService;
       _dbContext = dbContext;

       InitializeComponent();
      SetupUI();
        }

        private void InitializeComponent()
 {
       this.Text = "🧾 Phiếu Hoá Đơn Chuyên Nghiệp";
     this.Width = 900;
         this.Height = 1000;
   this.StartPosition = FormStartPosition.CenterScreen;
   this.BackColor = Color.White;
            this.Font = new Font("Arial", 10);
        }

        private void SetupUI()
     {
            var mainPanel = new Panel
            {
        Dock = DockStyle.Fill,
        BackColor = Color.White,
     Padding = new Padding(40)
    };

  rtbInvoice = new RichTextBox
    {
            Dock = DockStyle.Fill,
        ReadOnly = true,
          BackColor = Color.White,
      BorderStyle = BorderStyle.None,
       Font = new Font("Arial", 10)
      };

  mainPanel.Controls.Add(rtbInvoice);

            var btnPanel = new Panel
            {
    Dock = DockStyle.Bottom,
                Height = 60,
  BackColor = Color.White,
        Padding = new Padding(20)
     };

     var btnPrint = new Button
    {
    Text = "🖨️ In Hoá Đơn",
        Width = 120,
       Height = 40,
         BackColor = Color.FromArgb(59, 130, 246),
   ForeColor = Color.White,
       Font = new Font("Segoe UI", 10, FontStyle.Bold),
         FlatStyle = FlatStyle.Flat,
     Location = new Point(20, 10)
          };
            btnPrint.Click += (s, e) => PrintInvoice();

  var btnExportPdf = new Button
        {
    Text = "📄 Xuất PDF",
    Width = 120,
      Height = 40,
  BackColor = Color.FromArgb(116, 90, 255),
     ForeColor = Color.White,
           Font = new Font("Segoe UI", 10, FontStyle.Bold),
             FlatStyle = FlatStyle.Flat,
                Location = new Point(150, 10)
       };
 btnExportPdf.Click += (s, e) => ExportToPdf();

    var btnClose = new Button
            {
          Text = "✕ Đóng",
                Width = 120,
  Height = 40,
          BackColor = Color.FromArgb(107, 114, 128),
         ForeColor = Color.White,
             Font = new Font("Segoe UI", 10, FontStyle.Bold),
       FlatStyle = FlatStyle.Flat,
  Location = new Point(280, 10)
            };
            btnClose.Click += (s, e) => this.Close();

      btnPanel.Controls.Add(btnPrint);
            btnPanel.Controls.Add(btnExportPdf);
 btnPanel.Controls.Add(btnClose);

            this.Controls.Add(mainPanel);
    this.Controls.Add(btnPanel);
        }

 public async Task LoadInvoiceDataAsync()
     {
     try
         {
       var roomDetails = await _roomRentalDetailService.GetRoomRentalDetailsByRentalDetailIdAsync(_rentalDetail.RentalDetailId);
         var serviceDetails = await _dbContext.ServiceRentalDetails
     .Where(x => x.RentalDetailId == _rentalDetail.RentalDetailId)
             .ToListAsync();

        var employee = await _employeeService.GetEmployeeAsync(_rentalDetail.EmployeeId);

      int roomTotal = 0;
 foreach (var room in roomDetails)
    {
 int nights = Math.Max(1, (int)(room.ReturnDate - room.RentalDate).TotalDays);
 roomTotal += room.RentalPrice * nights;
      }

     int serviceTotal = serviceDetails.Sum(s => s.Price * s.Quantity);
         int subtotal = roomTotal + serviceTotal;
          int total = subtotal - _invoice.Discount + _invoice.Surcharge;

           string content = BuildInvoiceContent(
   roomDetails.ToList(),
   serviceDetails,
        employee?.Name ?? "N/A",
                roomTotal,
            serviceTotal,
  subtotal,
  total
 );

     rtbInvoice.Text = content;
            }
            catch (Exception ex)
         {
    MessageBox.Show($"Lỗi tải dữ liệu hoá đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }

  private string BuildInvoiceContent(
    List<RoomRentalDetail> roomDetails,
            List<ServiceRentalDetail> serviceDetails,
            string employeeName,
       int roomTotal,
            int serviceTotal,
  int subtotal,
       int total)
        {
        var sb = new System.Text.StringBuilder();

        // Header
          sb.AppendLine("═══════════════════════════════════════════════════════");
sb.AppendLine("       KHÁNH SẠN LUXURY");
            sb.AppendLine("  Địa chỉ: 273 An Dương Vương, Phường 3, Quận 5, TP HCM");
  sb.AppendLine("      Hotline Booking: 0987654321");
       sb.AppendLine("        Fax: 0987654321");
            sb.AppendLine("═══════════════════════════════════════════════════════");
   sb.AppendLine();

        // Invoice Info
sb.AppendLine("THÔNG TIN HÓA ĐƠN");
  sb.AppendLine("―――――――――――――――――――――――――――――――――――――――――――――――――――――――");
      sb.AppendLine($"Mã chi tiết thuê: {_rentalDetail.RentalDetailId}");
            sb.AppendLine($"Nhân viên lập hóa đơn: {employeeName}");
            sb.AppendLine($"Ngày lập hóa đơn: {_invoice.PaymentDate:HH:mm:ss dd/MM/yyyy}");
     sb.AppendLine();

            // Rooms Section
       sb.AppendLine("THÔNG TIN PHÒNG THUÊ");
 sb.AppendLine("―――――――――――――――――――――――――――――――――――――――――――――――――――――――");
            sb.AppendLine(string.Format("{0,-15} {1,-20} {2,-15} {3,-15} {4,-15}", 
                "TÊN PHÒNG", "LOẠI HÌNH THUÊ", "NGÀY THUÊ", "NGÀY CHECKOUT", "GIÁ THUÊ"));
            sb.AppendLine(new string('─', 80));

        foreach (var room in roomDetails)
  {
                int nights = Math.Max(1, (int)(room.ReturnDate - room.RentalDate).TotalDays);
  int roomPrice = room.RentalPrice * nights;
  string rentalType = "Theo ngày";
      
          sb.AppendLine(string.Format("{0,-15} {1,-20} {2,-15} {3,-15} {4,>14}", 
   room.RoomId, 
        rentalType, 
       room.RentalDate.ToString("dd/MM/yyyy"),
       room.CheckoutDate.ToString("dd/MM/yyyy"),
               $"{roomPrice:N0} VNĐ"));
        }

 sb.AppendLine();

            // Services Section
            if (serviceDetails.Count > 0)
  {
                sb.AppendLine("THÔNG TIN DỊCH VỤ THUÊ");
         sb.AppendLine("―――――――――――――――――――――――――――――――――――――――――――――――――――――――");
    sb.AppendLine(string.Format("{0,-25} {1,-20} {2,-15} {3,-10} {4,-12} {5,-15}", 
         "TÊN DỊCH VỤ", "LOẠI DỊCH VỤ", "NGÀY SỬ DỤNG", "SỐ LƯỢNG", "ĐƠN GIÁ", "THÀNH TIỀN"));
        sb.AppendLine(new string('─', 97));

 foreach (var service in serviceDetails)
                {
        int itemTotal = service.Price * service.Quantity;
    sb.AppendLine(string.Format("{0,-25} {1,-20} {2,-15} {3,-10} {4,>10} {5,>14}", 
       service.ServiceId,
     "Dịch vụ",
     service.UsageDate.ToString("dd/MM/yyyy"),
  service.Quantity,
       $"{service.Price:N0}",
      $"{itemTotal:N0} VNĐ"));
         }

          sb.AppendLine();
            }

            // Summary
   sb.AppendLine("THÔNG TIN THANH TOÁN");
       sb.AppendLine("―――――――――――――――――――――――――――――――――――――――――――――――――――――――");
       sb.AppendLine();
            sb.AppendLine($"  Tổng tiền phòng:      {roomTotal.ToString("N0"),15} VNĐ");
            
    if (serviceTotal > 0)
  sb.AppendLine($"  Tổng tiền dịch vụ:   {serviceTotal.ToString("N0"),15} VNĐ");

            sb.AppendLine($"  ──────────────────────────────────────────────");
 sb.AppendLine($"  Cộng tiền:{subtotal.ToString("N0"),15} VNĐ");

        if (_invoice.Discount > 0)
       sb.AppendLine($"  Giảm giá:    -{_invoice.Discount.ToString("N0"),14} VNĐ");

   if (_invoice.Surcharge > 0)
sb.AppendLine($"  Phụ thu:          +{_invoice.Surcharge.ToString("N0"),14} VNĐ");

  sb.AppendLine($"  ══════════════════════════════════════════════");
    sb.AppendLine($"  TỔNG CỘNG:      {total.ToString("N0"),15} VNĐ");
    sb.AppendLine();
  sb.AppendLine($"  Phương thức thanh toán: {GetPaymentMethodText(_invoice.PaymentMethod)}");

       return sb.ToString();
        }

        private string GetPaymentMethodText(int method)
        {
            return method switch
     {
          0 => "Tiền mặt",
       1 => "Thẻ tín dụng",
       2 => "Ví điện tử",
      3 => "Chuyển khoản",
                _ => "Khác"
         };
        }

        private void PrintInvoice()
   {
      var printDoc = new System.Drawing.Printing.PrintDocument();
            printDoc.PrintPage += (sender, e) =>
    {
e.Graphics.DrawString(rtbInvoice.Text, rtbInvoice.Font, Brushes.Black, 
     new Rectangle(50, 50, e.PageBounds.Width - 100, e.PageBounds.Height - 100));
  e.HasMorePages = false;
            };

    var preview = new System.Windows.Forms.PrintPreviewDialog { Document = printDoc, Width = 900, Height = 700 };
 preview.ShowDialog();
      }

        private void ExportToPdf()
   {
            MessageBox.Show("Tính năng xuất PDF đang phát triển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
