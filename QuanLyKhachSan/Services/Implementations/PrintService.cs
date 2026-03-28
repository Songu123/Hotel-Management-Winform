using System.Text;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Services.Implementations
{
    /// <summary>
    /// Service implementation cho in phiếu thuê
    /// </summary>
    public class PrintService : IPrintService
    {
  private readonly ICustomerService _customerService;
        private readonly IRoomService _roomService;

    public PrintService(ICustomerService customerService, IRoomService roomService)
    {
  _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
     _roomService = roomService ?? throw new ArgumentNullException(nameof(roomService));
        }

  /// <summary>
        /// Tạo HTML cho phiếu thuê
      /// </summary>
        public async Task<string> GenerateRentalDetailHtmlAsync(RentalDetail rentalDetail, List<RoomRentalDetail> roomDetails)
        {
       try
        {
       if (rentalDetail == null || roomDetails == null || !roomDetails.Any())
            throw new ArgumentException("Dữ liệu phiếu thuê không hợp lệ");

    // Get customer info
     var customer = await _customerService.GetCustomerAsync(rentalDetail.CustomerId);
   if (customer == null)
     throw new InvalidOperationException($"Khách hàng {rentalDetail.CustomerId} không tồn tại");

        // Calculate total
       int totalPrice = roomDetails.Sum(r => r.RentalPrice);

         // Build HTML
           var html = new StringBuilder();
           html.AppendLine("<!DOCTYPE html>");
    html.AppendLine("<html lang=\"vi\">");
      html.AppendLine("<head>");
        html.AppendLine("<meta charset=\"UTF-8\">");
        html.AppendLine("<title>Phiếu Thuê Phòng</title>");
         html.AppendLine("<style>");
    html.AppendLine("body { font-family: 'Segoe UI', Arial; margin: 20px; }");
   html.AppendLine(".container { max-width: 800px; margin: 0 auto; border: 1px solid #ccc; padding: 20px; }");
      html.AppendLine(".header { text-align: center; border-bottom: 2px solid #333; padding-bottom: 10px; margin-bottom: 20px; }");
            html.AppendLine(".header h1 { margin: 0; color: #333; }");
        html.AppendLine(".header p { margin: 5px 0; color: #666; }");
   html.AppendLine(".section { margin-bottom: 20px; }");
           html.AppendLine(".section-title { background-color: #f0f0f0; padding: 10px; font-weight: bold; border-left: 4px solid #2196F3; }");
        html.AppendLine(".section-content { padding: 10px 0; }");
  html.AppendLine(".row { display: grid; grid-template-columns: 1fr 1fr; gap: 20px; }");
         html.AppendLine(".field { margin-bottom: 10px; }");
   html.AppendLine(".field-label { font-weight: bold; color: #333; }");
          html.AppendLine(".field-value { color: #666; }");
          html.AppendLine("table { width: 100%; border-collapse: collapse; margin: 10px 0; }");
  html.AppendLine("th { background-color: #2196F3; color: white; padding: 10px; text-align: left; }");
             html.AppendLine("td { border-bottom: 1px solid #ddd; padding: 10px; }");
    html.AppendLine("tr:hover { background-color: #f5f5f5; }");
           html.AppendLine(".total { font-weight: bold; font-size: 1.2em; color: #d32f2f; }");
        html.AppendLine(".footer { text-align: center; border-top: 1px solid #ccc; padding-top: 10px; margin-top: 20px; }");
       html.AppendLine(".footer p { margin: 5px 0; font-size: 0.9em; color: #999; }");
  html.AppendLine("</style>");
          html.AppendLine("</head>");
       html.AppendLine("<body>");

   // Header
      html.AppendLine("<div class=\"container\">");
       html.AppendLine("<div class=\"header\">");
    html.AppendLine("<h1>🏨 PHIẾU THUÊ PHÒNG</h1>");
      html.AppendLine($"<p>Khách sạn Quản Lý - Hotel Management System</p>");
           html.AppendLine("</div>");

      // Rental Info
      html.AppendLine("<div class=\"section\">");
     html.AppendLine("<div class=\"section-title\">THÔNG TIN PHIẾU THUÊ</div>");
       html.AppendLine("<div class=\"section-content\">");
       html.AppendLine("<div class=\"row\">");
      html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Mã Phiếu Thuê:</div><div class=\"field-value\">{rentalDetail.RentalDetailId}</div></div>");
          html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Ngày Lập Phiếu:</div><div class=\"field-value\">{rentalDetail.CreatedDate:dd/MM/yyyy HH:mm:ss}</div></div>");
               html.AppendLine("</div>");
html.AppendLine("<div class=\"row\">");
  html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Nhân Viên Lập:</div><div class=\"field-value\">{rentalDetail.EmployeeId}</div></div>");
     html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Tình Trạng Xử Lý:</div><div class=\"field-value\">{GetProcessingStatusName(rentalDetail.ProcessingStatus)}</div></div>");
          html.AppendLine("</div>");
      html.AppendLine("<div class=\"row\">");
          html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Tiền Đặt Cọc:</div><div class=\"field-value\">{rentalDetail.DepositAmount:N0} VNĐ</div></div>");
         html.AppendLine("</div>");
   html.AppendLine("</div>");
         html.AppendLine("</div>");

// Customer Info
  html.AppendLine("<div class=\"section\">");
      html.AppendLine("<div class=\"section-title\">THÔNG TIN KHÁCH HÀNG</div>");
       html.AppendLine("<div class=\"section-content\">");
 html.AppendLine("<div class=\"row\">");
           html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Mã Khách Hàng:</div><div class=\"field-value\">{customer.CustomerId}</div></div>");
  html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Họ Tên:</div><div class=\"field-value\">{customer.Name}</div></div>");
   html.AppendLine("</div>");
    html.AppendLine("<div class=\"row\">");
  html.AppendLine($"<div class=\"field\"><div class=\"field-label\">CMND/CCCD:</div><div class=\"field-value\">{customer.IdNumber}</div></div>");
   html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Số Điện Thoại:</div><div class=\"field-value\">{customer.PhoneNumber}</div></div>");
 html.AppendLine("</div>");
            html.AppendLine("<div class=\"row\">");
    html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Ngày Sinh:</div><div class=\"field-value\">{customer.DateOfBirth:dd/MM/yyyy}</div></div>");
      html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Giới Tính:</div><div class=\"field-value\">{GetGenderName(customer.Gender)}</div></div>");
   html.AppendLine("</div>");
     html.AppendLine("<div class=\"row\">");
      html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Địa Chỉ:</div><div class=\"field-value\">{customer.Address}</div></div>");
   html.AppendLine("</div>");
      html.AppendLine("<div class=\"row\">");
  html.AppendLine($"<div class=\"field\"><div class=\"field-label\">Quốc Tịch:</div><div class=\"field-value\">{customer.Nationality}</div></div>");
        html.AppendLine("</div>");
    html.AppendLine("</div>");
         html.AppendLine("</div>");

      // Room Details
     html.AppendLine("<div class=\"section\">");
     html.AppendLine("<div class=\"section-title\">CHI TIẾT PHÒNG THUÊ</div>");
         html.AppendLine("<div class=\"section-content\">");
       html.AppendLine("<table>");
        html.AppendLine("<thead>");
         html.AppendLine("<tr>");
          html.AppendLine("<th>STT</th>");
      html.AppendLine("<th>Mã Phòng</th>");
           html.AppendLine("<th>Ngày Thuê</th>");
       html.AppendLine("<th>Ngày Trả</th>");
html.AppendLine("<th>Giá Phòng</th>");
       html.AppendLine("</tr>");
      html.AppendLine("</thead>");
   html.AppendLine("<tbody>");

  int stt = 1;
foreach (var room in roomDetails)
    {
            html.AppendLine("<tr>");
          html.AppendLine($"<td>{stt}</td>");
         html.AppendLine($"<td>{room.RoomId}</td>");
      html.AppendLine($"<td>{room.RentalDate:dd/MM/yyyy}</td>");
    html.AppendLine($"<td>{room.ReturnDate:dd/MM/yyyy}</td>");
       html.AppendLine($"<td class=\"total\">{room.RentalPrice:N0} VNĐ</td>");
         html.AppendLine("</tr>");
  stt++;
 }

     html.AppendLine("</tbody>");
      html.AppendLine("</table>");
      html.AppendLine("</div>");
    html.AppendLine("</div>");

      // Summary
html.AppendLine("<div class=\"section\">");
  html.AppendLine("<div class=\"section-title\">TỔNG KẾT</div>");
     html.AppendLine("<div class=\"section-content\">");
       html.AppendLine($"<div style=\"font-size: 1.3em; color: #d32f2f; text-align: right;\">");
      html.AppendLine($"<strong>Tổng Tiền: {totalPrice:N0} VNĐ</strong>");
            html.AppendLine($"<br /><strong>Tiền Đặt Cọc: {rentalDetail.DepositAmount:N0} VNĐ</strong>");
          html.AppendLine($"<br /><strong>Còn Lại: {(totalPrice - rentalDetail.DepositAmount):N0} VNĐ</strong>");
         html.AppendLine("</div>");
  html.AppendLine("</div>");
     html.AppendLine("</div>");

      // Footer
 html.AppendLine("<div class=\"footer\">");
    html.AppendLine("<p>📧 Email: khachsan@example.com | 📞 Hotline: 0123-456-789</p>");
  html.AppendLine($"<p>⏰ In lúc: {DateTime.Now:dd/MM/yyyy HH:mm:ss}</p>");
           html.AppendLine("</div>");

       html.AppendLine("</div>");
  html.AppendLine("</body>");
         html.AppendLine("</html>");

       return html.ToString();
     }
       catch (Exception ex)
  {
     throw new Exception("Lỗi khi tạo HTML phiếu thuê", ex);
       }
 }

   /// <summary>
     /// In phiếu thuê
    /// </summary>
  public async Task<bool> PrintRentalDetailAsync(RentalDetail rentalDetail, List<RoomRentalDetail> roomDetails)
    {
   try
       {
        var html = await GenerateRentalDetailHtmlAsync(rentalDetail, roomDetails);

          // Tạo temporary file
       var tempFile = Path.Combine(Path.GetTempPath(), $"PhieuThue_{rentalDetail.RentalDetailId}.html");
             await File.WriteAllTextAsync(tempFile, html);

      // Open with default browser
    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(tempFile) { UseShellExecute = true });

    return true;
 }
     catch (Exception ex)
   {
 throw new Exception("Lỗi khi in phiếu thuê", ex);
         }
      }

      /// <summary>
         /// Lưu phiếu thuê dưới dạng PDF (tạm dùng HTML)
       /// </summary>
      public async Task<bool> SaveRentalDetailAsPdfAsync(RentalDetail rentalDetail, List<RoomRentalDetail> roomDetails, string filePath)
   {
          try
    {
         var html = await GenerateRentalDetailHtmlAsync(rentalDetail, roomDetails);

          // Tạo file HTML (có thể cải tiến thành PDF sau)
    var directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
   {
        Directory.CreateDirectory(directory);
     }

        // Nếu filePath không có extension, thêm .html
  if (!filePath.EndsWith(".html", StringComparison.OrdinalIgnoreCase))
 {
         filePath = Path.ChangeExtension(filePath, ".html");
  }

      await File.WriteAllTextAsync(filePath, html);

    return true;
     }
           catch (Exception ex)
       {
 throw new Exception("Lỗi khi lưu phiếu thuê", ex);
     }
     }

        /// <summary>
      /// Xem trước phiếu thuê
       /// </summary>
    public async Task<string> PreviewRentalDetailAsync(RentalDetail rentalDetail, List<RoomRentalDetail> roomDetails)
    {
          try
    {
  return await GenerateRentalDetailHtmlAsync(rentalDetail, roomDetails);
     }
   catch (Exception ex)
         {
    throw new Exception("Lỗi khi xem trước phiếu thuê", ex);
          }
     }

     // Helper methods
     private string GetProcessingStatusName(int status)
      {
    return status switch
     {
              0 => "Đang xử lý",
        1 => "Đã xác nhận",
             2 => "Đã hủy",
            _ => "Không xác định"
           };
      }

    private string GetGenderName(int gender)
 {
     return gender switch
        {
        0 => "Nữ",
      1 => "Nam",
       _ => "Khác"
     };
    }
    }
}
