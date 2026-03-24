using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;

namespace QuanLyKhachSan.Repositories.Implementations
{
    /// <summary>
    /// Customer Repository implementation
    /// </summary>
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(HotelDbContext context) : base(context)
        {
        }

        public async Task<Customer?> GetByPhoneNumberAsync(string phoneNumber)
        {
            return await _dbSet.FirstOrDefaultAsync(c => c.PhoneNumber == phoneNumber);
        }

        public async Task<Customer?> GetByIdNumberAsync(string idNumber)
        {
            return await _dbSet.FirstOrDefaultAsync(c => c.IdNumber == idNumber);
        }

        public async Task<IEnumerable<Customer>> SearchByNameAsync(string name)
        {
            return await _dbSet
     .Where(c => c.Name.Contains(name))
         .ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _dbSet
       .Where(c => c.IsDeleted == 0)
       .OrderBy(c => c.Name)
      .ToListAsync();
        }

        public async Task<Customer?> GetCustomerWithDetailsAsync(string customerId)
        {
            return await _dbSet
 .Where(c => c.CustomerId == customerId && c.IsDeleted == 0)
    .Include(c => c.RentalDetails)
    .FirstOrDefaultAsync();
        }
    }
}
