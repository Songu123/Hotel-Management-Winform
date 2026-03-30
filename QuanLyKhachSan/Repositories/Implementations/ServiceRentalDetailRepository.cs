using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;

namespace QuanLyKhachSan.Repositories.Implementations
{
    /// <summary>
    /// ServiceRentalDetail Repository implementation
    /// </summary>
    public class ServiceRentalDetailRepository : IRepository<ServiceRentalDetail>
    {
        protected readonly HotelDbContext _context;
    protected readonly DbSet<ServiceRentalDetail> _dbSet;

        public ServiceRentalDetailRepository(HotelDbContext context)
        {
      _context = context;
     _dbSet = context.Set<ServiceRentalDetail>();
      }

        public virtual async Task<IEnumerable<ServiceRentalDetail>> GetAllAsync()
        {
      return await _dbSet.ToListAsync();
        }

        public virtual async Task<ServiceRentalDetail?> GetByIdAsync(int id)
        {
         throw new NotImplementedException("ServiceRentalDetail uses composite key");
        }

        public virtual async Task AddAsync(ServiceRentalDetail entity)
{
          await _dbSet.AddAsync(entity);
        }

public virtual async Task AddRangeAsync(IEnumerable<ServiceRentalDetail> entities)
        {
    await _dbSet.AddRangeAsync(entities);
        }

        public virtual async Task UpdateAsync(ServiceRentalDetail entity)
{
 _dbSet.Update(entity);
        await Task.CompletedTask;
        }

        public virtual async Task UpdateRangeAsync(IEnumerable<ServiceRentalDetail> entities)
  {
          _dbSet.UpdateRange(entities);
     await Task.CompletedTask;
        }

        public virtual async Task DeleteAsync(int id)
        {
          throw new NotImplementedException("ServiceRentalDetail uses composite key");
        }

    public virtual async Task DeleteAsync(ServiceRentalDetail entity)
        {
   _dbSet.Remove(entity);
            await Task.CompletedTask;
        }

        public virtual async Task DeleteRangeAsync(IEnumerable<ServiceRentalDetail> entities)
        {
  _dbSet.RemoveRange(entities);
          await Task.CompletedTask;
        }

    public virtual async Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException("ServiceRentalDetail uses composite key");
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
