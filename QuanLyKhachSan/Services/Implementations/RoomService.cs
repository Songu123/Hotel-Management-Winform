using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Services.Implementations
{
  public class RoomService : IRoomService
    {
   private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
      }

       public async Task<IEnumerable<Room>> GetAllRoomsAsync()
        {
 return await _roomRepository.GetAllAsync();
        }

        public async Task<Room?> GetRoomAsync(string roomId)
        {
            return await _roomRepository.GetRoomWithTypeAsync(roomId);
    }

        public async Task<Room> CreateRoomAsync(Room room)
        {
      room.IsDeleted = 0;
       room.Status = 0;
            await _roomRepository.AddAsync(room);
         await _roomRepository.SaveChangesAsync();
   return room;
        }

        public async Task<bool> UpdateRoomAsync(Room room)
  {
            await _roomRepository.UpdateAsync(room);
       await _roomRepository.SaveChangesAsync();
         return true;
        }

        public async Task<bool> DeleteRoomAsync(string roomId)
        {
            var room = await _roomRepository.GetRoomWithTypeAsync(roomId);
    if (room == null)
            {
         return false;
         }

            room.IsDeleted = 1;
      await _roomRepository.UpdateAsync(room);
       await _roomRepository.SaveChangesAsync();
            return true;
        }

    public async Task<List<Room>> GetAvailableRoomsByTypeAndDateAsync(int roomTypeId, DateTime checkInDate, DateTime checkOutDate)
   {
        return await _roomRepository.FindAvailableRoomsAsync(roomTypeId, checkInDate, checkOutDate);
        }

   public async Task<bool> UpdateRoomStatusAsync(string roomId, int newStatus)
        {
         return await _roomRepository.UpdateRoomStatusAsync(roomId, newStatus);
 }

   public async Task<IEnumerable<Room>> GetAvailableRoomsAsync()
        {
 return await _roomRepository.GetAvailableRoomsAsync();
        }

      public async Task<IEnumerable<Room>> GetMaintenanceRoomsAsync()
        {
return await _roomRepository.GetMaintenanceRoomsAsync();
}

    public async Task<decimal> CalculateRoomRevenueAsync(DateTime startDate, DateTime endDate)
        {
     return 0;
   }

        public async Task<Dictionary<int, int>> GetRoomStatusStatisticsAsync()
        {
   var allRooms = await GetAllRoomsAsync();
       var statistics = allRooms
    .GroupBy(r => r.Status)
         .ToDictionary(g => g.Key, g => g.Count());

    return statistics;
  }

        public async Task<IEnumerable<Room>> SearchRoomsAsync(string searchTerm)
        {
       if (string.IsNullOrWhiteSpace(searchTerm))
 return await GetAllRoomsAsync();

     return await _roomRepository.SearchRoomsAsync(searchTerm);
        }

  public async Task<IEnumerable<Room>> FilterByStatusAsync(int status)
    {
          var allRooms = await GetAllRoomsAsync();
        return allRooms.Where(r => r.Status == status);
        }

        public async Task<IEnumerable<Room>> FilterByRoomTypeAsync(int roomTypeId)
{
            var allRooms = await GetAllRoomsAsync();
      return allRooms.Where(r => r.RoomType == roomTypeId);
     }

 public async Task<IEnumerable<Room>> FilterByStatusAndTypeAsync(int status, int roomTypeId)
     {
       var allRooms = await GetAllRoomsAsync();
       return allRooms.Where(r => r.Status == status && r.RoomType == roomTypeId);
        }

        public async Task<IEnumerable<Room>> SearchAndFilterRoomsAsync(string? searchTerm, int? status, int? roomTypeId)
        {
            return await _roomRepository.SearchAndFilterRoomsAsync(searchTerm, status, roomTypeId);
        }
  }
}
