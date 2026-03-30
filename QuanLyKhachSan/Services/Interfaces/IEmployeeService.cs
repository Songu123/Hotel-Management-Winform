using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Service interface cho Employee
    /// </summary>
    public interface IEmployeeService
    {
   /// <summary>
        /// Lấy tất cả nhân viên
        /// </summary>
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();

        /// <summary>
        /// Lấy nhân viên theo ID
        /// </summary>
        Task<Employee?> GetEmployeeAsync(string employeeId);

        /// <summary>
        /// Tạo nhân viên mới
        /// </summary>
        Task<Employee> CreateEmployeeAsync(Employee employee);

        /// <summary>
/// Cập nhật thông tin nhân viên
    /// </summary>
Task<bool> UpdateEmployeeAsync(Employee employee);

        /// <summary>
        /// Xóa nhân viên
        /// </summary>
    Task<bool> DeleteEmployeeAsync(string employeeId);

    /// <summary>
        /// Tìm nhân viên theo email
      /// </summary>
        Task<Employee?> GetByEmailAsync(string email);

        /// <summary>
 /// Tìm kiếm nhân viên theo tên
        /// </summary>
   Task<IEnumerable<Employee>> SearchByNameAsync(string name);

   /// <summary>
        /// Tìm kiếm và lọc nhân viên
        /// </summary>
      Task<IEnumerable<Employee>> SearchAndFilterEmployeesAsync(
     string? employeeId = null,
            string? name = null,
            int? position = null,
        int? gender = null,
            string? email = null,
 DateTime? startDateFrom = null,
         DateTime? startDateTo = null);

        /// <summary>
        /// Kiểm tra nhân viên có tồn tại hay không
        /// </summary>
 Task<bool> EmployeeExistsAsync(string employeeId);

        /// <summary>
        /// Lấy nhân viên cùng với chi tiết thuê phòng
    /// </summary>
Task<Employee?> GetEmployeeWithDetailsAsync(string employeeId);
    }
}
