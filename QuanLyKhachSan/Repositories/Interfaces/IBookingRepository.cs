using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Repositories.Interfaces
{
    /// <summary>
    /// Repository interface cho Booking entity
    /// </summary>
    public interface IBookingRepository : IRepository<Booking>
    {
      /// <summary>
        /// Lấy booking theo trạng thái
        /// </summary>
        Task<IEnumerable<Booking>> GetByStatusAsync(BookingStatus status);

        /// <summary>
        /// Lấy booking của khách hàng
        /// </summary>
        Task<IEnumerable<Booking>> GetByCustomerAsync(int customerId);

  /// <summary>
      /// Lấy booking của phòng
      /// </summary>
        Task<IEnumerable<Booking>> GetByRoomAsync(int roomId);

        /// <summary>
        /// Lấy booking trong khoảng ngày
        /// </summary>
        Task<IEnumerable<Booking>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);

   /// <summary>
        /// Kiểm tra phòng có đã được đặt trong khoảng ngày không
 /// </summary>
        Task<bool> IsRoomBookedAsync(int roomId, DateTime checkInDate, DateTime checkOutDate);

        /// <summary>
   /// Lấy booking với thông tin liên quan (Customer, Room, Invoices)
        /// </summary>
Task<Booking?> GetBookingWithDetailsAsync(int bookingId);

  /// <summary>
        /// Lấy booking sắp check-in
  /// </summary>
        Task<IEnumerable<Booking>> GetUpcomingCheckInsAsync(int daysAhead = 7);

        /// <summary>
        /// Lấy booking đã hoàn tất
        /// </summary>
        Task<IEnumerable<Booking>> GetCompletedBookingsAsync();

        /// <summary>
        /// Cập nhật trạng thái booking
        /// </summary>
        Task<bool> UpdateBookingStatusAsync(int bookingId, BookingStatus newStatus);
    }
}
