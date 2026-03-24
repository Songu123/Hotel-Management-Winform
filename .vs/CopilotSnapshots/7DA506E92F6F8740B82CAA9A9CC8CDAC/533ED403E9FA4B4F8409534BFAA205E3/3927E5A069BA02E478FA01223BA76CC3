using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Service interface cho Booking
    /// </summary>
    public interface IBookingService
    {
        /// <summary>
        /// Tạo booking mới
        /// </summary>
        Task<Booking?> CreateBookingAsync(int customerId, int roomId, DateTime checkInDate, DateTime checkOutDate);

        /// <summary>
        /// Lấy booking theo ID
        /// </summary>
        Task<Booking?> GetBookingAsync(int bookingId);

        /// <summary>
        /// Cập nhật booking
        /// </summary>
        Task<bool> UpdateBookingAsync(Booking booking);

        /// <summary>
        /// Hủy booking
        /// </summary>
        Task<bool> CancelBookingAsync(int bookingId);

        /// <summary>
        /// Check-in cho booking
        /// </summary>
        Task<bool> CheckInBookingAsync(int bookingId);

        /// <summary>
        /// Check-out cho booking
        /// </summary>
        Task<bool> CheckOutBookingAsync(int bookingId);

        /// <summary>
        /// Lấy booking của khách hàng
        /// </summary>
        Task<IEnumerable<Booking>> GetCustomerBookingsAsync(int customerId);

        /// <summary>
        /// Lấy booking sắp check-in
        /// </summary>
        Task<IEnumerable<Booking>> GetUpcomingBookingsAsync();

        /// <summary>
        /// Kiểm tra phòng có sẵn trong khoảng ngày không
        /// </summary>
        Task<bool> IsRoomAvailableAsync(string roomId, DateTime checkInDate, DateTime checkOutDate);

        /// <summary>
        /// Tính giá booking
        /// </summary>
        Task<decimal> CalculateTotalPriceAsync(string roomId, DateTime checkInDate, DateTime checkOutDate);

        /// <summary>
        /// Lấy tất cả booking
        /// </summary>
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
    }
}
