using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
  /// Service quản lý dọn phòng
    /// </summary>
    public interface IRoomCleaningService
    {
        /// <summary>
     /// Bắt đầu dọn phòng
        /// </summary>
        Task<RoomCleaning> StartCleaningAsync(string roomId, string employeeId, string notes = "");

        /// <summary>
        /// Hoàn thành dọn phòng
        /// </summary>
    Task<bool> CompleteCleaningAsync(string cleaningId, int roomConditionAfter, string notes = "");

      /// <summary>
        /// Hủy dọn phòng
        /// </summary>
        Task<bool> CancelCleaningAsync(string cleaningId);

        /// <summary>
        /// Lấy tất cả lịch sử dọn phòng
        /// </summary>
        Task<IEnumerable<RoomCleaning>> GetAllCleaningsAsync();

  /// <summary>
  /// Lấy lịch sử dọn phòng theo phòng
        /// </summary>
    Task<IEnumerable<RoomCleaning>> GetCleaningsByRoomAsync(string roomId);

 /// <summary>
    /// Lấy lịch sử dọn phòng theo nhân viên
   /// </summary>
        Task<IEnumerable<RoomCleaning>> GetCleaningsByEmployeeAsync(string employeeId);

        /// <summary>
        /// Lấy phòng đang được dọn
        /// </summary>
     Task<IEnumerable<RoomCleaning>> GetOngoingCleaningsAsync();

        /// <summary>
        /// Lấy lịch sử dọn phòng gần nhất
     /// </summary>
        Task<RoomCleaning?> GetLatestCleaningAsync(string roomId);

        /// <summary>
    /// Kiểm tra xem phòng có đang được dọn không
        /// </summary>
        Task<bool> IsRoomCleaningAsync(string roomId);

  /// <summary>
    /// Lấy thống kê dọn phòng theo khoảng thời gian
        /// </summary>
        Task<Dictionary<string, int>> GetCleaningStatisticsAsync(DateTime startDate, DateTime endDate);
    }
}
