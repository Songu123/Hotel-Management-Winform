using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Repositories.Interfaces
{
    /// <summary>
    /// Repository interface cho Room entity
    /// </summary>
    public interface IRoomRepository : IRepository<Room>
    {
        /// <summary>
        /// Tìm phòng theo số phòng
        /// </summary>
        Task<Room?> GetByRoomNumberAsync(string roomNumber);

        /// <summary>
        /// Lấy phòng theo loại và trạng thái
        /// </summary>
        Task<IEnumerable<Room>> GetByRoomTypeAndStatusAsync(int roomTypeId, int status);

        /// <summary>
        /// Lấy các phòng còn trống
        /// </summary>
        Task<IEnumerable<Room>> GetAvailableRoomsAsync();

        /// <summary>
        /// Lấy các phòng còn trống theo loại
        /// </summary>
        Task<IEnumerable<Room>> GetAvailableRoomsByTypeAsync(int roomTypeId);

        /// <summary>
        /// Lấy phòng đang bảo trì
        /// </summary>
        Task<IEnumerable<Room>> GetMaintenanceRoomsAsync();

        /// <summary>
        /// Cập nhật trạng thái phòng
        /// </summary>
        Task<bool> UpdateRoomStatusAsync(string roomId, int newStatus);

        /// <summary>
        /// Lấy phòng với thông tin loại phòng
        /// </summary>
        Task<Room?> GetRoomWithTypeAsync(string roomId);

        /// <summary>
        /// Tìm phòng trống trong khoảng ngày cho loại phòng
        /// </summary>
        Task<List<Room>> FindAvailableRoomsAsync(int roomTypeId, DateTime checkInDate, DateTime checkOutDate);

        /// <summary>
        /// Tìm kiếm phòng theo số phòng hoặc loại phòng (với thông tin chi tiết)
        /// </summary>
        Task<IEnumerable<Room>> SearchRoomsAsync(string searchTerm);

        /// <summary>
        /// Tìm kiếm và lọc phòng với nhiều tiêu chí
        /// </summary>
        Task<IEnumerable<Room>> SearchAndFilterRoomsAsync(string? searchTerm, int? status, int? roomTypeId);
    }
}
