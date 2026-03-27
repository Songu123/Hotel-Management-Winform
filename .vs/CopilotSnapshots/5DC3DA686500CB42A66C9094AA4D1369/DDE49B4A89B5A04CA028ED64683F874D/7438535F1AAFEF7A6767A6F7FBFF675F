using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;

namespace QuanLyKhachSan.Repositories.Implementations
{
    /// <summary>
    /// Repository quản lý dọn phòng
    /// </summary>
    public class RoomCleaningRepository : Repository<RoomCleaning>, IRoomCleaningRepository
    {
        public RoomCleaningRepository(HotelDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Lấy tất cả lịch sử dọn phòng theo phòng
        /// </summary>
        public async Task<IEnumerable<RoomCleaning>> GetByRoomIdAsync(string roomId)
        {
            try
            {
                return await _dbSet
                    .Where(c => c.RoomId == roomId && c.IsDeleted == 0)
                    .OrderByDescending(c => c.StartTime)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy lịch sử dọn phòng: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy tất cả lịch sử dọn phòng theo nhân viên
        /// </summary>
        public async Task<IEnumerable<RoomCleaning>> GetByEmployeeIdAsync(string employeeId)
        {
            try
            {
                return await _dbSet
                    .Where(c => c.EmployeeId == employeeId && c.IsDeleted == 0)
                    .OrderByDescending(c => c.StartTime)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy lịch sử dọn phòng: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy lịch sử dọn phòng theo khoảng thời gian
        /// </summary>
        public async Task<IEnumerable<RoomCleaning>> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            try
            {
                return await _dbSet
                    .Where(c => c.StartTime >= startDate && c.StartTime <= endDate && c.IsDeleted == 0)
                    .OrderByDescending(c => c.StartTime)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy lịch sử dọn phòng: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy những phòng đang được dọn
        /// </summary>
        public async Task<IEnumerable<RoomCleaning>> GetOngoingCleaningsAsync()
        {
            try
            {
                return await _dbSet
                    .Where(c => c.Status == 0 && c.IsDeleted == 0) // 0: Đang thực hiện
                    .OrderByDescending(c => c.StartTime)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy phòng đang dọn: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy lịch sử dọn phòng theo trạng thái
        /// </summary>
        public async Task<IEnumerable<RoomCleaning>> GetByStatusAsync(int status)
        {
            try
            {
                return await _dbSet
                    .Where(c => c.Status == status && c.IsDeleted == 0)
                    .OrderByDescending(c => c.StartTime)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy lịch sử dọn phòng: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Kiểm tra xem phòng có đang được dọn không
        /// </summary>
        public async Task<bool> IsRoomCleaningAsync(string roomId)
        {
            try
            {
                var cleaning = await _dbSet
                    .FirstOrDefaultAsync(c => c.RoomId == roomId && c.Status == 0 && c.IsDeleted == 0);
                return cleaning != null;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy lịch sử dọn phòng gần nhất
        /// </summary>
        public async Task<RoomCleaning?> GetLatestCleaningAsync(string roomId)
        {
            try
            {
                return await _dbSet
                    .Where(c => c.RoomId == roomId && c.IsDeleted == 0)
                    .OrderByDescending(c => c.StartTime)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy lịch sử dọn phòng gần nhất: {ex.Message}", ex);
            }
        }
    }
}
