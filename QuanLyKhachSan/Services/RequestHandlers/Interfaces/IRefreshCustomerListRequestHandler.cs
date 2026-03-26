using QuanLyKhachSan.Services.RequestHandlers.Dtos;
using QuanLyKhachSan.Services.RequestHandlers.Results;

namespace QuanLyKhachSan.Services.RequestHandlers.Interfaces
{
    /// <summary>
    /// Interface cho handler xử lý yêu cầu làm mới danh sách khách hàng
    /// </summary>
    public interface IRefreshCustomerListRequestHandler
    {
     /// <summary>
        /// Xử lý yêu cầu làm mới danh sách khách hàng
     /// </summary>
        /// <param name="request">Yêu cầu làm mới</param>
       /// <returns>Kết quả xử lý</returns>
        Task<RefreshCustomerListResult> HandleAsync(RefreshCustomerListRequest request);

        /// <summary>
      /// Lấy danh sách khách hàng
   /// </summary>
      Task<IEnumerable<Models.Customer>> GetCustomersAsync();
    }
}
