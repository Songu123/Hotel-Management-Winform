using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Repositories.Interfaces
{
    /// <summary>
    /// Repository interface cho Customer entity
    /// </summary>
    public interface ICustomerRepository : IRepository<Customer>
    {
        /// <summary>
     /// Tìm khách hàng theo số điện thoại
     /// </summary>
        Task<Customer?> GetByPhoneNumberAsync(string phoneNumber);

        /// <summary>
        /// Tìm khách hàng theo số giấy tờ tùy thân
        /// </summary>
        Task<Customer?> GetByIdNumberAsync(string idNumber);

        /// <summary>
        /// Tìm khách hàng theo tên (tìm kiếm gần đúng)
        /// </summary>
        Task<IEnumerable<Customer>> SearchByNameAsync(string name);

        /// <summary>
        /// Lấy tất cả khách hàng (chưa xóa)
        /// </summary>
        Task<IEnumerable<Customer>> GetAllCustomersAsync();

        /// <summary>
        /// Lấy khách hàng cùng với chi tiết thuê phòng
        /// </summary>
        Task<Customer?> GetCustomerWithDetailsAsync(string customerId);
    }
}
