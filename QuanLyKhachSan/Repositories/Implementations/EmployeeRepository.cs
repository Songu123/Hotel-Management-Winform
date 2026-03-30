using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Repositories.Implementations
{
    /// <summary>
    /// Employee Repository implementation
    /// </summary>
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository(HotelDbContext context) : base(context)
        {
        }

  public async Task<Employee?> GetByEmailAsync(string email)
     {
            return await _dbSet.FirstOrDefaultAsync(e => e.Email == email);
        }

    public async Task<IEnumerable<Employee>> SearchByNameAsync(string name)
        {
        return await _dbSet
     .Where(e => e.Name.Contains(name))
      .ToListAsync();
  }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _dbSet
       .Where(e => e.IsDeleted == 0)
 .OrderBy(e => e.Name)
         .ToListAsync();
        }

        public async Task<Employee?> GetEmployeeWithDetailsAsync(string employeeId)
        {
      return await _dbSet
       .Where(e => e.EmployeeId == employeeId && e.IsDeleted == 0)
          .Include(e => e.RentalDetails)
                .FirstOrDefaultAsync();
  }
    }
}
