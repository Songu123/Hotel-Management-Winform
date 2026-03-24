using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Repositories.Interfaces
{
    /// <summary>
    /// Repository interface cho Invoice entity
    /// </summary>
    public interface IInvoiceRepository : IRepository<Invoice>
    {
     /// <summary>
        /// Lấy hóa đơn theo ID
  /// </summary>
        Task<Invoice?> GetByIdAsync(string invoiceId);

  /// <summary>
     /// Lấy hóa đơn theo chi tiết thuê phòng
        /// </summary>
     Task<IEnumerable<Invoice>> GetByRentalDetailAsync(string rentalDetailId);

      /// <summary>
     /// Lấy hóa đơn theo khoảng ngày
    /// </summary>
    Task<IEnumerable<Invoice>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);

        /// <summary>
        /// Lấy tất cả hóa đơn (chưa xóa)
  /// </summary>
        Task<IEnumerable<Invoice>> GetAllInvoicesAsync();

 /// <summary>
   /// Tính tổng tiền từ tất cả hóa đơn
    /// </summary>
     Task<decimal> GetTotalAmountAsync();

 /// <summary>
     /// Tạo số hóa đơn mới
 /// </summary>
    Task<string> GenerateInvoiceNumberAsync();
    }
}
