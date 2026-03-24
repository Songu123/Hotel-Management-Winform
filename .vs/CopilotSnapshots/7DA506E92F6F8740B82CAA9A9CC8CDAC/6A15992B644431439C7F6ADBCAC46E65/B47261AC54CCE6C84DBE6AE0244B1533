using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Service interface cho Room
    /// </summary>
    public interface IRoomService
    {
        /// <summary>
        /// Lấy tất cả phòng
        /// </summary>
        Task<IEnumerable<Room>> GetAllRoomsAsync();

        /// <summary>
        /// Lấy phòng theo ID
        /// </summary>
        Task<Room?> GetRoomAsync(string roomId);

        /// <summary>
        /// Tạo phòng mới
        /// </summary>
        Task<Room> CreateRoomAsync(Room room);

        /// <summary>
        /// Cập nhật thông tin phòng
        /// </summary>
        Task<bool> UpdateRoomAsync(Room room);

        /// <summary>
        /// Xóa phòng
        /// </summary>
        Task<bool> DeleteRoomAsync(string roomId);

        /// <summary>
        /// Lấy phòng trống theo loại trong khoảng ngày
        /// </summary>
        Task<List<Room>> GetAvailableRoomsByTypeAndDateAsync(int roomTypeId, DateTime checkInDate, DateTime checkOutDate);

        /// <summary>
        /// Cập nhật trạng thái phòng
        /// </summary>
        Task<bool> UpdateRoomStatusAsync(string roomId, int newStatus);

        /// <summary>
        /// Lấy các phòng trống
        /// </summary>
        Task<IEnumerable<Room>> GetAvailableRoomsAsync();

        /// <summary>
        /// Lấy các phòng đang bảo trì
        /// </summary>
        Task<IEnumerable<Room>> GetMaintenanceRoomsAsync();

        /// <summary>
        /// Tính tổng doanh thu từ phòng trong khoảng ngày
        /// </summary>
        Task<decimal> CalculateRoomRevenueAsync(DateTime startDate, DateTime endDate);

        /// <summary>
        /// Lấy thống kê phòng theo trạng thái
        /// </summary>
        Task<Dictionary<int, int>> GetRoomStatusStatisticsAsync();

        /// <summary>
        /// Tìm kiếm phòng theo số phòng hoặc loại phòng
        /// </summary>
        Task<IEnumerable<Room>> SearchRoomsAsync(string searchTerm);

        /// <summary>
        /// Lọc phòng theo trạng thái
        /// </summary>
        Task<IEnumerable<Room>> FilterByStatusAsync(int status);

        /// <summary>
        /// Lọc phòng theo loại phòng
        /// </summary>
        Task<IEnumerable<Room>> FilterByRoomTypeAsync(int roomTypeId);

        /// <summary>
        /// Lọc phòng theo trạng thái và loại phòng
        /// </summary>
        Task<IEnumerable<Room>> FilterByStatusAndTypeAsync(int status, int roomTypeId);

        /// <summary>
        /// Tìm kiếm và lọc phòng với nhiều tiêu chí
        /// </summary>
        Task<IEnumerable<Room>> SearchAndFilterRoomsAsync(string? searchTerm, int? status, int? roomTypeId);
    }
}
