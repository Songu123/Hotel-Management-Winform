using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Service interface cho Service (Dịch vụ)
    /// </summary>
    public interface IServiceService
    {
  /// <summary>
  /// Lấy tất cả dịch vụ
   /// </summary>
        Task<IEnumerable<Service>> GetAllServicesAsync();

        /// <summary>
        /// Lấy dịch vụ theo ID
      /// </summary>
  Task<Service?> GetServiceAsync(string serviceId);

     /// <summary>
        /// Tạo dịch vụ mới
      /// </summary>
        Task<Service> CreateServiceAsync(Service service);

        /// <summary>
        /// Cập nhật dịch vụ
        /// </summary>
        Task<bool> UpdateServiceAsync(Service service);

    /// <summary>
        /// Xóa dịch vụ
        /// </summary>
        Task<bool> DeleteServiceAsync(string serviceId);

 /// <summary>
        /// Tìm kiếm dịch vụ theo tên
        /// </summary>
  Task<IEnumerable<Service>> SearchByNameAsync(string name);

        /// <summary>
        /// Lọc dịch vụ theo loại
        /// </summary>
    Task<IEnumerable<Service>> FilterByTypeAsync(string type);

        /// <summary>
        /// Kiểm tra dịch vụ có tồn tại hay không
  /// </summary>
    Task<bool> ServiceExistsAsync(string serviceId);
    }
}
