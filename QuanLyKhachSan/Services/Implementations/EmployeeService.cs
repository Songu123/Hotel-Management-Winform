using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Implementations;
using QuanLyKhachSan.Repositories.Interfaces;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Services.Implementations
{
    /// <summary>
    /// Service for managing employees
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository)
 {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
    }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
    {
    try
       {
         var allEmployees = await _employeeRepository.GetAllAsync();
     return allEmployees.Where(e => e.IsDeleted == 0).ToList();
       }
      catch (Exception ex)
            {
          throw new Exception("Lỗi khi lấy danh sách nhân viên", ex);
 }
        }

  public async Task<Employee?> GetEmployeeAsync(string employeeId)
        {
         try
            {
         if (string.IsNullOrWhiteSpace(employeeId))
    return null;

         var allEmployees = await GetAllEmployeesAsync();
      return allEmployees.FirstOrDefault(e => e.EmployeeId == employeeId);
            }
catch (Exception ex)
            {
      throw new Exception($"Lỗi khi lấy nhân viên {employeeId}", ex);
  }
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
    try
  {
           if (employee == null)
            throw new ArgumentNullException(nameof(employee));

   // Validate required fields
       if (string.IsNullOrWhiteSpace(employee.EmployeeId))
        throw new ArgumentException("Mã nhân viên không được để trống");

    if (string.IsNullOrWhiteSpace(employee.Name))
          throw new ArgumentException("Tên nhân viên không được để trống");

        if (string.IsNullOrWhiteSpace(employee.Email))
      throw new ArgumentException("Email không được để trống");

     // Check if employee ID already exists
      var allEmployees = await GetAllEmployeesAsync();
    var existing = allEmployees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
          if (existing != null)
      throw new InvalidOperationException($"Mã nhân viên {employee.EmployeeId} đã tồn tại");

        // Check if email already exists
                var emailExists = allEmployees.FirstOrDefault(e => e.Email == employee.Email);
      if (emailExists != null)
         throw new InvalidOperationException($"Email {employee.Email} đã được sử dụng");

employee.IsDeleted = 0;
                await _employeeRepository.AddAsync(employee);
   await _employeeRepository.SaveChangesAsync();

  return employee;
   }
          catch (Exception ex)
  {
     throw new Exception("Lỗi khi tạo nhân viên mới", ex);
            }
        }

        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            try
        {
            if (employee == null)
         throw new ArgumentNullException(nameof(employee));

      // Validate required fields
    if (string.IsNullOrWhiteSpace(employee.Name))
              throw new ArgumentException("Tên nhân viên không được để trống");

 if (string.IsNullOrWhiteSpace(employee.Email))
     throw new ArgumentException("Email không được để trống");

              var allEmployees = await GetAllEmployeesAsync();
          var existing = allEmployees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
        if (existing == null)
            throw new InvalidOperationException($"Nhân viên {employee.EmployeeId} không tồn tại");

     // Check if email is used by another employee
       var emailExists = allEmployees.FirstOrDefault(e => e.Email == employee.Email && e.EmployeeId != employee.EmployeeId);
        if (emailExists != null)
   throw new InvalidOperationException($"Email {employee.Email} đã được sử dụng");

                existing.Name = employee.Name;
      existing.Email = employee.Email;
      existing.Gender = employee.Gender;
     existing.Position = employee.Position;
                existing.DateOfBirth = employee.DateOfBirth;
              existing.StartDate = employee.StartDate;
    existing.DailySalary = employee.DailySalary;
                existing.DaysOff = employee.DaysOff;

    await _employeeRepository.UpdateAsync(existing);
     await _employeeRepository.SaveChangesAsync();

         return true;
            }
        catch (Exception ex)
            {
 throw new Exception("Lỗi khi cập nhật nhân viên", ex);
         }
        }

   public async Task<bool> DeleteEmployeeAsync(string employeeId)
        {
     try
            {
     if (string.IsNullOrWhiteSpace(employeeId))
         throw new ArgumentException("Mã nhân viên không được để trống");

          var allEmployees = await GetAllEmployeesAsync();
  var employee = allEmployees.FirstOrDefault(e => e.EmployeeId == employeeId);
     if (employee == null)
          throw new InvalidOperationException($"Nhân viên {employeeId} không tồn tại");

       employee.IsDeleted = 1;
     await _employeeRepository.UpdateAsync(employee);
      await _employeeRepository.SaveChangesAsync();

          return true;
        }
            catch (Exception ex)
        {
  throw new Exception("Lỗi khi xóa nhân viên", ex);
            }
        }

        public async Task<Employee?> GetByEmailAsync(string email)
        {
  try
  {
             if (string.IsNullOrWhiteSpace(email))
 return null;

    var allEmployees = await GetAllEmployeesAsync();
        return allEmployees.FirstOrDefault(e => e.Email == email);
 }
  catch (Exception ex)
  {
      throw new Exception("Lỗi khi tìm nhân viên theo email", ex);
  }
        }

        public async Task<IEnumerable<Employee>> SearchByNameAsync(string name)
  {
            try
        {
                if (string.IsNullOrWhiteSpace(name))
         return await GetAllEmployeesAsync();

       var allEmployees = await GetAllEmployeesAsync();
          return allEmployees.Where(e => e.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
       }
   catch (Exception ex)
{
       throw new Exception("Lỗi khi tìm kiếm nhân viên theo tên", ex);
    }
        }

        public async Task<IEnumerable<Employee>> SearchAndFilterEmployeesAsync(
            string? employeeId = null,
  string? name = null,
      int? position = null,
            int? gender = null,
       string? email = null,
     DateTime? startDateFrom = null,
 DateTime? startDateTo = null)
   {
            try
            {
        var allEmployees = await GetAllEmployeesAsync();
                var filtered = allEmployees.AsEnumerable();

            // Filter by employee ID
      if (!string.IsNullOrWhiteSpace(employeeId))
       filtered = filtered.Where(e => e.EmployeeId.Contains(employeeId, StringComparison.OrdinalIgnoreCase));

        // Filter by name
           if (!string.IsNullOrWhiteSpace(name))
   filtered = filtered.Where(e => e.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

      // Filter by position
   if (position.HasValue && position.Value >= 0)
              filtered = filtered.Where(e => e.Position == position.Value);

       // Filter by gender
if (gender.HasValue && gender.Value >= 0)
     filtered = filtered.Where(e => e.Gender == gender.Value);

        // Filter by email
      if (!string.IsNullOrWhiteSpace(email))
                 filtered = filtered.Where(e => e.Email.Contains(email, StringComparison.OrdinalIgnoreCase));

                // Filter by start date
     if (startDateFrom.HasValue)
  filtered = filtered.Where(e => e.StartDate >= startDateFrom.Value);

          if (startDateTo.HasValue)
  filtered = filtered.Where(e => e.StartDate <= startDateTo.Value);

   return filtered.OrderBy(e => e.Name).ToList();
     }
         catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm và lọc nhân viên", ex);
    }
     }

     public async Task<bool> EmployeeExistsAsync(string employeeId)
        {
      try
   {
        if (string.IsNullOrWhiteSpace(employeeId))
   return false;

          var allEmployees = await GetAllEmployeesAsync();
        return allEmployees.Any(e => e.EmployeeId == employeeId);
  }
       catch (Exception ex)
  {
   throw new Exception("Lỗi khi kiểm tra nhân viên tồn tại", ex);
         }
    }

      public async Task<Employee?> GetEmployeeWithDetailsAsync(string employeeId)
{
       try
            {
     if (string.IsNullOrWhiteSpace(employeeId))
      return null;

          var employee = await GetEmployeeAsync(employeeId);
        return employee;
      }
     catch (Exception ex)
            {
    throw new Exception("Lỗi khi lấy chi tiết nhân viên", ex);
      }
        }
    }
}
