using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;

namespace QuanLyKhachSan.Repositories.Implementations
{
    /// <summary>
    /// RentalDetail Repository implementation
    /// </summary>
    public class RentalDetailRepository : IRepository<RentalDetail>
    {
     protected readonly HotelDbContext _context;
        protected readonly DbSet<RentalDetail> _dbSet;

        public RentalDetailRepository(HotelDbContext context)
        {
        _context = context;
            _dbSet = context.Set<RentalDetail>();
   }

     public virtual async Task<IEnumerable<RentalDetail>> GetAllAsync()
   {
      return await _dbSet.ToListAsync();
   }

        public virtual async Task<RentalDetail?> GetByIdAsync(int id)
 {
  throw new NotImplementedException("Sử dụng GetByIdAsync(string) thay thế");
        }

        /// <summary>
        /// Get RentalDetail by string ID
        /// </summary>
        public virtual async Task<RentalDetail?> GetByIdAsync(string id)
        {
      return await _dbSet.FirstOrDefaultAsync(r => r.RentalDetailId == id);
        }

        public virtual async Task AddAsync(RentalDetail entity)
      {
     await _dbSet.AddAsync(entity);
      }

        public virtual async Task AddRangeAsync(IEnumerable<RentalDetail> entities)
        {
         await _dbSet.AddRangeAsync(entities);
        }

    public virtual async Task UpdateAsync(RentalDetail entity)
        {
    _dbSet.Update(entity);
        await Task.CompletedTask;
}

        public virtual async Task UpdateRangeAsync(IEnumerable<RentalDetail> entities)
      {
     _dbSet.UpdateRange(entities);
            await Task.CompletedTask;
  }

     public virtual async Task DeleteAsync(int id)
   {
      throw new NotImplementedException("Sử dụng DeleteAsync(RentalDetail) thay thế");
    }

        public virtual async Task DeleteAsync(RentalDetail entity)
{
     _dbSet.Remove(entity);
     await Task.CompletedTask;
      }

        public virtual async Task DeleteRangeAsync(IEnumerable<RentalDetail> entities)
        {
     _dbSet.RemoveRange(entities);
            await Task.CompletedTask;
}

        public virtual async Task<bool> ExistsAsync(int id)
        {
        throw new NotImplementedException("Sử dụng ExistsAsync(string) thay thế");
        }

    public virtual async Task<int> CountAsync()
     {
       return await _dbSet.CountAsync();
        }

 public virtual async Task SaveChangesAsync()
        {
    await _context.SaveChangesAsync();
        }

     /// <summary>
        /// Check if rental detail exists
        /// </summary>
        public virtual async Task<bool> ExistsAsync(string id)
        {
       return await _dbSet.AnyAsync(r => r.RentalDetailId == id);
        }
    }
}
