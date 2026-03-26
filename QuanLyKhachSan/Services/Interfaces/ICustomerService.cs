using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Service interface cho Customer
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        /// Lấy tất cả khách hàng
        /// </summary>
        Task<IEnumerable<Customer>> GetAllCustomersAsync();

    /// <summary>
   /// Lấy khách hàng theo ID
        /// </summary>
        Task<Customer?> GetCustomerAsync(string customerId);

        /// <summary>
        /// Tạo khách hàng mới
      /// </summary>
   Task<Customer> CreateCustomerAsync(Customer customer);

      /// <summary>
        /// Cập nhật thông tin khách hàng
        /// </summary>
        Task<bool> UpdateCustomerAsync(Customer customer);

 /// <summary>
    /// Xóa khách hàng
        /// </summary>
        Task<bool> DeleteCustomerAsync(string customerId);

 /// <summary>
   /// Tìm khách hàng theo số điện thoại
        /// </summary>
        Task<Customer?> GetByPhoneNumberAsync(string phoneNumber);

    /// <summary>
        /// Tìm khách hàng theo CMND/CCCD
        /// </summary>
        Task<Customer?> GetByIdNumberAsync(string idNumber);

   /// <summary>
        /// Tìm kiếm khách hàng theo tên
      /// </summary>
        Task<IEnumerable<Customer>> SearchByNameAsync(string name);

 /// <summary>
        /// Tìm kiếm và lọc khách hàng
        /// </summary>
        Task<IEnumerable<Customer>> SearchAndFilterCustomersAsync(
            string? customerId = null,
string? name = null,
            string? idNumber = null,
       int? gender = null,
 string? phoneNumber = null,
        string? nationality = null,
   string? address = null,
  DateTime? dateOfBirthFrom = null,
        DateTime? dateOfBirthTo = null);

        /// <summary>
        /// Kiểm tra khách hàng có tồn tại hay không
        /// </summary>
        Task<bool> CustomerExistsAsync(string customerId);

    /// <summary>
     /// Kiểm tra CMND/CCCD đã được sử dụng chưa
        /// </summary>
        Task<bool> IdNumberAlreadyExistsAsync(string idNumber, string? excludeCustomerId = null);

        /// <summary>
     /// Lấy khách hàng cùng với chi tiết thuê phòng
        /// </summary>
        Task<Customer?> GetCustomerWithDetailsAsync(string customerId);
    }
}
