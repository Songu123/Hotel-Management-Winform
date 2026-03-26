using QuanLyKhachSan.Services.RequestHandlers.Dtos;
using QuanLyKhachSan.Services.RequestHandlers.Results;

namespace QuanLyKhachSan.Services.RequestHandlers.Interfaces
{
 /// <summary>
    /// Interface cho handler xử lý yêu cầu tạo khách hàng mới
    /// </summary>
    public interface ICustomerCreateRequestHandler
    {
        /// <summary>
        /// Xử lý yêu cầu tạo khách hàng
        /// </summary>
   /// <param name="request">Yêu cầu tạo khách hàng</param>
    /// <returns>Kết quả xử lý</returns>
        Task<CustomerCreateResult> HandleAsync(CustomerCreateRequest request);
    }
}
