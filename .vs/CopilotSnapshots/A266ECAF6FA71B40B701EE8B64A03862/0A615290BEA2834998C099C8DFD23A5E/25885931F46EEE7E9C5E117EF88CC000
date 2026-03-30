using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;

namespace QuanLyKhachSan.Repositories.Implementations
{
    /// <summary>
    /// Repository interface cho Service (Dịch vụ)
    /// </summary>
    public interface IServiceRepository : IRepository<Service>
    {
        // Uses base IRepository<Service>
        // Override GetByIdAsync in implementation to work with strings
    }

    /// <summary>
    /// Repository implementation cho Service
    /// </summary>
    public class ServiceRepository : IServiceRepository
    {
        protected readonly HotelDbContext _context;
        protected readonly DbSet<Service> _dbSet;

        public ServiceRepository(HotelDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Service>();
        }

        public virtual async Task<IEnumerable<Service>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<Service?> GetByIdAsync(int id)
        {
            throw new NotImplementedException("Service uses string ID, use GetByIdAsyncString");
        }

        /// <summary>
        /// Get Service by string ID
        /// </summary>
        public async Task<Service?> GetByIdAsyncString(string serviceId)
        {
            return await _dbSet.FirstOrDefaultAsync(s => s.ServiceId == serviceId);
        }

        public virtual async Task AddAsync(Service entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual async Task AddRangeAsync(IEnumerable<Service> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public virtual async Task UpdateAsync(Service entity)
        {
            _dbSet.Update(entity);
            await Task.CompletedTask;
        }

        public virtual async Task UpdateRangeAsync(IEnumerable<Service> entities)
        {
            _dbSet.UpdateRange(entities);
            await Task.CompletedTask;
        }

        public virtual async Task DeleteAsync(int id)
        {
            throw new NotImplementedException("Service uses string ID");
        }

        public virtual async Task DeleteAsync(Service entity)
        {
            _dbSet.Remove(entity);
            await Task.CompletedTask;
        }

        public virtual async Task DeleteRangeAsync(IEnumerable<Service> entities)
        {
            _dbSet.RemoveRange(entities);
            await Task.CompletedTask;
        }

        public virtual async Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException("Service uses string ID");
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
