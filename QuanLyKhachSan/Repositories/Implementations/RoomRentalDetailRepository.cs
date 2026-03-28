using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;

namespace QuanLyKhachSan.Repositories.Implementations
{
    /// <summary>
    /// RoomRentalDetail Repository implementation
    /// </summary>
    public class RoomRentalDetailRepository : IRepository<RoomRentalDetail>
    {
      protected readonly HotelDbContext _context;
    protected readonly DbSet<RoomRentalDetail> _dbSet;

    public RoomRentalDetailRepository(HotelDbContext context)
        {
     _context = context;
     _dbSet = context.Set<RoomRentalDetail>();
      }

 public virtual async Task<IEnumerable<RoomRentalDetail>> GetAllAsync()
        {
      return await _dbSet.ToListAsync();
        }

   public virtual async Task<RoomRentalDetail?> GetByIdAsync(int id)
    {
 throw new NotImplementedException("RoomRentalDetail uses composite key");
    }

  public virtual async Task AddAsync(RoomRentalDetail entity)
        {
     await _dbSet.AddAsync(entity);
      }

        public virtual async Task AddRangeAsync(IEnumerable<RoomRentalDetail> entities)
        {
   await _dbSet.AddRangeAsync(entities);
        }

    public virtual async Task UpdateAsync(RoomRentalDetail entity)
      {
      _dbSet.Update(entity);
    await Task.CompletedTask;
        }

    public virtual async Task UpdateRangeAsync(IEnumerable<RoomRentalDetail> entities)
  {
        _dbSet.UpdateRange(entities);
      await Task.CompletedTask;
        }

        public virtual async Task DeleteAsync(int id)
    {
     throw new NotImplementedException("RoomRentalDetail uses composite key");
    }

    public virtual async Task DeleteAsync(RoomRentalDetail entity)
    {
     _dbSet.Remove(entity);
     await Task.CompletedTask;
        }

   public virtual async Task DeleteRangeAsync(IEnumerable<RoomRentalDetail> entities)
        {
       _dbSet.RemoveRange(entities);
            await Task.CompletedTask;
        }

        public virtual async Task<bool> ExistsAsync(int id)
        {
         throw new NotImplementedException("RoomRentalDetail uses composite key");
   }

     public virtual async Task<int> CountAsync()
 {
    return await _dbSet.CountAsync();
      }

 public virtual async Task SaveChangesAsync()
        {
          await _context.SaveChangesAsync();
   }
    }
}
