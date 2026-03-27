using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Repositories.Interfaces
{
    /// <summary>
    /// Interface cho repository quản lý dọn phòng
    /// </summary>
    public interface IRoomCleaningRepository : IRepository<RoomCleaning>
    {
        /// <summary>
        /// Lấy tất cả lịch sử dọn phòng theo phòng
        /// </summary>
        Task<IEnumerable<RoomCleaning>> GetByRoomIdAsync(string roomId);

    /// <summary>
        /// Lấy tất cả lịch sử dọn phòng theo nhân viên
      /// </summary>
        Task<IEnumerable<RoomCleaning>> GetByEmployeeIdAsync(string employeeId);

        /// <summary>
        /// Lấy lịch sử dọn phòng theo khoảng thời gian
        /// </summary>
        Task<IEnumerable<RoomCleaning>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);

    /// <summary>
     /// Lấy những phòng đang được dọn
     /// </summary>
      Task<IEnumerable<RoomCleaning>> GetOngoingCleaningsAsync();

      /// <summary>
        /// Lấy lịch sử dọn phòng theo trạng thái
        /// </summary>
  Task<IEnumerable<RoomCleaning>> GetByStatusAsync(int status);

        /// <summary>
/// Kiểm tra xem phòng có đang được dọn không
        /// </summary>
        Task<bool> IsRoomCleaningAsync(string roomId);

        /// <summary>
        /// Lấy lịch sử dọn phòng gần nhất
        /// </summary>
        Task<RoomCleaning?> GetLatestCleaningAsync(string roomId);
    }
}
