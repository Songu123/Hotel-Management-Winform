using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Service interface cho Invoice
    /// </summary>
  public interface IInvoiceService
    {
   /// <summary>
    /// Tạo hóa đơn mới cho chi tiết thuê phòng
 /// </summary>
    Task<Invoice?> CreateInvoiceAsync(string rentalDetailId);

        /// <summary>
/// Lấy hóa đơn theo ID
        /// </summary>
    Task<Invoice?> GetInvoiceAsync(string invoiceId);

 /// <summary>
  /// Cập nhật hóa đơn
     /// </summary>
  Task<bool> UpdateInvoiceAsync(Invoice invoice);

/// <summary>
        /// Thanh toán hóa đơn
/// </summary>
 Task<bool> PayInvoiceAsync(string invoiceId, int discount, int surcharge);

      /// <summary>
 /// Lấy hóa đơn theo khoảng ngày
   /// </summary>
  Task<IEnumerable<Invoice>> GetInvoicesByDateRangeAsync(DateTime startDate, DateTime endDate);


        /// <summary>
 /// Lấy tất cả hóa đơn
      /// </summary>
     Task<IEnumerable<Invoice>> GetAllInvoicesAsync();

     /// <summary>
        /// Tính tổng doanh thu
  /// </summary>
   Task<decimal> GetTotalRevenueAsync();

        /// <summary>
     /// Tạo số hóa đơn mới
 /// </summary>
  Task<string> GenerateInvoiceNumberAsync();
    }
}
