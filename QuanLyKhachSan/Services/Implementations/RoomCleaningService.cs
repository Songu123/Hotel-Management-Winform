using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Services.Implementations
{
    /// <summary>
    /// Service quản lý dọn phòng
    /// </summary>
    public class RoomCleaningService : IRoomCleaningService
    {
        private readonly IRoomCleaningRepository _cleaningRepository;
        private readonly IRoomRepository _roomRepository;

        public RoomCleaningService(IRoomCleaningRepository cleaningRepository, IRoomRepository roomRepository)
        {
       _cleaningRepository = cleaningRepository ?? throw new ArgumentNullException(nameof(cleaningRepository));
 _roomRepository = roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));
   }

  /// <summary>
        /// Bắt đầu dọn phòng
        /// </summary>
        public async Task<RoomCleaning> StartCleaningAsync(string roomId, string employeeId, string notes = "")
        {
          try
         {
              if (string.IsNullOrWhiteSpace(roomId))
       throw new ArgumentException("Mã phòng không được để trống", nameof(roomId));

     if (string.IsNullOrWhiteSpace(employeeId))
               throw new ArgumentException("Mã nhân viên không được để trống", nameof(employeeId));

       // Check if room is already cleaning
 if (await IsRoomCleaningAsync(roomId))
   throw new InvalidOperationException($"Phòng {roomId} đang được dọn, không thể bắt đầu dọn mới");

 // Create cleaning record
         var cleaning = new RoomCleaning
{
            CleaningId = $"DP{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}",
   RoomId = roomId,
   EmployeeId = employeeId,
         StartTime = DateTime.Now,
  RoomConditionBefore = 0,
         RoomConditionAfter = 0,
           Notes = notes,
 Status = 0, // 0: Đang thực hiện
 IsDeleted = 0
     };

           await _cleaningRepository.AddAsync(cleaning);
        await _cleaningRepository.SaveChangesAsync();

   // Update room status to cleaning (2)
          var room = await _roomRepository.GetRoomWithTypeAsync(roomId);
      if (room != null)
       {
            room.Status = 2; // Cleaning
            await _roomRepository.UpdateAsync(room);
    await _roomRepository.SaveChangesAsync();
      }

          return cleaning;
   }
     catch (Exception ex)
            {
    throw new Exception($"Lỗi khi bắt đầu dọn phòng: {ex.Message}", ex);
            }
        }

        /// <summary>
  /// Hoàn thành dọn phòng
     /// </summary>
        public async Task<bool> CompleteCleaningAsync(string cleaningId, int roomConditionAfter, string notes = "")
        {
    try
    {
          if (string.IsNullOrWhiteSpace(cleaningId))
        throw new ArgumentException("Mã dọn phòng không được để trống", nameof(cleaningId));

            // Get cleaning record
    var allCleanings = await _cleaningRepository.GetAllAsync();
                var cleaning = allCleanings.FirstOrDefault(c => c.CleaningId == cleaningId && c.IsDeleted == 0);

      if (cleaning == null)
   throw new InvalidOperationException($"Không tìm thấy lịch sử dọn phòng {cleaningId}");

    if (cleaning.Status != 0)
           throw new InvalidOperationException("Chỉ có thể hoàn thành dọn phòng đang thực hiện");

          // Update cleaning record
          cleaning.EndTime = DateTime.Now;
     cleaning.RoomConditionAfter = roomConditionAfter;
        cleaning.Notes = notes;
    cleaning.Status = 1; // 1: Hoàn thành

       await _cleaningRepository.UpdateAsync(cleaning);
       await _cleaningRepository.SaveChangesAsync();

                // Update room status back to available (0)
       var room = await _roomRepository.GetRoomWithTypeAsync(cleaning.RoomId);
  if (room != null)
        {
         room.Status = 0; // Available
         room.CurrentCondition = roomConditionAfter;
       await _roomRepository.UpdateAsync(room);
        await _roomRepository.SaveChangesAsync();
        }

       return true;
         }
      catch (Exception ex)
            {
     throw new Exception($"Lỗi khi hoàn thành dọn phòng: {ex.Message}", ex);
      }
     }

        /// <summary>
        /// Hủy dọn phòng
        /// </summary>
        public async Task<bool> CancelCleaningAsync(string cleaningId)
        {
            try
       {
                if (string.IsNullOrWhiteSpace(cleaningId))
   throw new ArgumentException("Mã dọn phòng không được để trống", nameof(cleaningId));

            // Get cleaning record
   var allCleanings = await _cleaningRepository.GetAllAsync();
   var cleaning = allCleanings.FirstOrDefault(c => c.CleaningId == cleaningId && c.IsDeleted == 0);

    if (cleaning == null)
              throw new InvalidOperationException($"Không tìm thấy lịch sử dọn phòng {cleaningId}");

     // Update cleaning record
      cleaning.Status = 2; // 2: Hủy
          cleaning.IsDeleted = 1;

    await _cleaningRepository.UpdateAsync(cleaning);
             await _cleaningRepository.SaveChangesAsync();

    // Update room status back to available (0)
     var room = await _roomRepository.GetRoomWithTypeAsync(cleaning.RoomId);
          if (room != null)
        {
          room.Status = 0; // Available
            await _roomRepository.UpdateAsync(room);
    await _roomRepository.SaveChangesAsync();
           }

          return true;
         }
        catch (Exception ex)
      {
            throw new Exception($"Lỗi khi hủy dọn phòng: {ex.Message}", ex);
            }
 }

        /// <summary>
        /// Lấy tất cả lịch sử dọn phòng
   /// </summary>
        public async Task<IEnumerable<RoomCleaning>> GetAllCleaningsAsync()
   {
            try
         {
    return await _cleaningRepository.GetAllAsync();
 }
            catch (Exception ex)
         {
     throw new Exception($"Lỗi khi lấy lịch sử dọn phòng: {ex.Message}", ex);
    }
        }

        /// <summary>
    /// Lấy lịch sử dọn phòng theo phòng
        /// </summary>
        public async Task<IEnumerable<RoomCleaning>> GetCleaningsByRoomAsync(string roomId)
     {
      try
  {
                if (string.IsNullOrWhiteSpace(roomId))
   return Enumerable.Empty<RoomCleaning>();

       return await _cleaningRepository.GetByRoomIdAsync(roomId);
        }
            catch (Exception ex)
       {
  throw new Exception($"Lỗi khi lấy lịch sử dọn phòng: {ex.Message}", ex);
    }
      }

      /// <summary>
        /// Lấy lịch sử dọn phòng theo nhân viên
        /// </summary>
        public async Task<IEnumerable<RoomCleaning>> GetCleaningsByEmployeeAsync(string employeeId)
        {
 try
            {
 if (string.IsNullOrWhiteSpace(employeeId))
   return Enumerable.Empty<RoomCleaning>();

       return await _cleaningRepository.GetByEmployeeIdAsync(employeeId);
            }
     catch (Exception ex)
            {
    throw new Exception($"Lỗi khi lấy lịch sử dọn phòng: {ex.Message}", ex);
     }
        }

      /// <summary>
        /// Lấy phòng đang được dọn
        /// </summary>
        public async Task<IEnumerable<RoomCleaning>> GetOngoingCleaningsAsync()
        {
    try
     {
       return await _cleaningRepository.GetOngoingCleaningsAsync();
            }
  catch (Exception ex)
     {
         throw new Exception($"Lỗi khi lấy phòng đang dọn: {ex.Message}", ex);
  }
      }

        /// <summary>
        /// Lấy lịch sử dọn phòng gần nhất
  /// </summary>
      public async Task<RoomCleaning?> GetLatestCleaningAsync(string roomId)
        {
      try
            {
                if (string.IsNullOrWhiteSpace(roomId))
      return null;

                return await _cleaningRepository.GetLatestCleaningAsync(roomId);
  }
    catch (Exception ex)
            {
      throw new Exception($"Lỗi khi lấy lịch sử dọn phòng gần nhất: {ex.Message}", ex);
 }
        }

        /// <summary>
        /// Kiểm tra xem phòng có đang được dọn không
        /// </summary>
  public async Task<bool> IsRoomCleaningAsync(string roomId)
        {
            try
       {
           if (string.IsNullOrWhiteSpace(roomId))
        return false;

      return await _cleaningRepository.IsRoomCleaningAsync(roomId);
            }
  catch
            {
       return false;
     }
        }

     /// <summary>
        /// Lấy thống kê dọn phòng theo khoảng thời gian
      /// </summary>
   public async Task<Dictionary<string, int>> GetCleaningStatisticsAsync(DateTime startDate, DateTime endDate)
        {
    try
      {
       var cleanings = await _cleaningRepository.GetByDateRangeAsync(startDate, endDate);

    return new Dictionary<string, int>
           {
 { "Total", cleanings.Count() },
  { "Completed", cleanings.Count(c => c.Status == 1) },
     { "Cancelled", cleanings.Count(c => c.Status == 2) },
           { "Ongoing", cleanings.Count(c => c.Status == 0) }
                };
   }
            catch (Exception ex)
            {
          throw new Exception($"Lỗi khi lấy thống kê dọn phòng: {ex.Message}", ex);
     }
        }
    }
}
