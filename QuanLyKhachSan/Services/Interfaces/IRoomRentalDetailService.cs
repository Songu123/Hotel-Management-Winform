using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Service interface cho RoomRentalDetail (Chi tiết phòng trong chi tiết thuê)
    /// </summary>
    public interface IRoomRentalDetailService
    {
      /// <summary>
    /// Thêm chi tiết phòng thuê mới
        /// </summary>
        Task<bool> AddRoomRentalDetailAsync(RoomRentalDetail roomRentalDetail);

        /// <summary>
        /// Thêm nhiều chi tiết phòng thuê
  /// </summary>
        Task<bool> AddRoomRentalDetailsAsync(IEnumerable<RoomRentalDetail> roomRentalDetails);

        /// <summary>
        /// Lấy chi tiết phòng thuê theo ID chi tiết thuê
        /// </summary>
        Task<IEnumerable<RoomRentalDetail>> GetRoomRentalDetailsByRentalDetailIdAsync(string rentalDetailId);

  /// <summary>
      /// Lấy chi tiết phòng thuê theo ID phòng
        /// </summary>
        Task<IEnumerable<RoomRentalDetail>> GetRoomRentalDetailsByRoomIdAsync(string roomId);

        /// <summary>
        /// Cập nhật chi tiết phòng thuê
        /// </summary>
        Task<bool> UpdateRoomRentalDetailAsync(RoomRentalDetail roomRentalDetail);

      /// <summary>
        /// Xóa chi tiết phòng thuê
   /// </summary>
      Task<bool> DeleteRoomRentalDetailAsync(string rentalDetailId, string roomId, DateTime rentalDate);

      /// <summary>
   /// Xóa tất cả chi tiết phòng của một chi tiết thuê
        /// </summary>
    Task<bool> DeleteAllRoomRentalDetailsByRentalDetailIdAsync(string rentalDetailId);

        /// <summary>
        /// Lấy chi tiết phòng thuê cùng với thông tin phòng
      /// </summary>
        Task<IEnumerable<RoomRentalDetail>> GetRoomRentalDetailsWithRoomAsync(string rentalDetailId);

        /// <summary>
  /// Tính tổng tiền cho chi tiết thuê
        /// </summary>
  Task<int> CalculateTotalPriceAsync(string rentalDetailId);
    }
}
