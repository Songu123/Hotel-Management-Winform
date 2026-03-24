using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;

namespace QuanLyKhachSan.Repositories.Implementations
{
    /// <summary>
    /// Booking Repository implementation
    /// </summary>
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
  public BookingRepository(HotelDbContext context) : base(context)
      {
   }

     public async Task<IEnumerable<Booking>> GetByStatusAsync(BookingStatus status)
       {
    return await _dbSet
 .Where(b => b.Status == status)
      .Include(b => b.Customer)
   .Include(b => b.Room)
         .ThenInclude(r => r.RoomType)
 .ToListAsync();
   }

      public async Task<IEnumerable<Booking>> GetByCustomerAsync(int customerId)
   {
 return await _dbSet
 .Where(b => b.CustomerId == customerId)
        .Include(b => b.Room)
      .ThenInclude(r => r.RoomType)
.OrderByDescending(b => b.CreatedDate)
   .ToListAsync();
   }

      public async Task<IEnumerable<Booking>> GetByRoomAsync(int roomId)
     {
 return await _dbSet
     .Where(b => b.RoomId == roomId)
.Include(b => b.Customer)
    .OrderByDescending(b => b.CheckInDate)
      .ToListAsync();
  }

      public async Task<IEnumerable<Booking>> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
   {
 return await _dbSet
.Where(b => b.CheckInDate >= startDate && b.CheckOutDate <= endDate)
      .Include(b => b.Customer)
     .Include(b => b.Room)
   .ThenInclude(r => r.RoomType)
    .ToListAsync();
   }

      public async Task<bool> IsRoomBookedAsync(int roomId, DateTime checkInDate, DateTime checkOutDate)
 {
  return await _dbSet.AnyAsync(b =>
   b.RoomId == roomId &&
  (b.CheckInDate < checkOutDate && b.CheckOutDate > checkInDate) &&
  (b.Status == BookingStatus.Confirmed || b.Status == BookingStatus.CheckedIn)
 );
 }

      public async Task<Booking?> GetBookingWithDetailsAsync(int bookingId)
    {
  return await _dbSet
      .Include(b => b.Customer)
         .Include(b => b.Room)
    .ThenInclude(r => r.RoomType)
      .Include(b => b.Invoices)
        .FirstOrDefaultAsync(b => b.BookingId == bookingId);
     }

   public async Task<IEnumerable<Booking>> GetUpcomingCheckInsAsync(int daysAhead = 7)
  {
    var targetDate = DateTime.Now.AddDays(daysAhead);
    return await _dbSet
  .Where(b => b.CheckInDate >= DateTime.Now && b.CheckInDate <= targetDate && b.Status == BookingStatus.Confirmed)
          .Include(b => b.Customer)
  .Include(b => b.Room)
  .ThenInclude(r => r.RoomType)
      .OrderBy(b => b.CheckInDate)
   .ToListAsync();
  }

     public async Task<IEnumerable<Booking>> GetCompletedBookingsAsync()
 {
      return await _dbSet
     .Where(b => b.Status == BookingStatus.CheckedOut)
    .Include(b => b.Customer)
      .Include(b => b.Room)
 .OrderByDescending(b => b.CheckOutDate)
      .ToListAsync();
 }

   public async Task<bool> UpdateBookingStatusAsync(int bookingId, BookingStatus newStatus)
  {
      var booking = await GetByIdAsync(bookingId);
 if (booking == null)
      {
return false;
  }

  booking.Status = newStatus;
      booking.UpdatedDate = DateTime.Now;
   await UpdateAsync(booking);
     await SaveChangesAsync();
 return true;
    }
  }
}
