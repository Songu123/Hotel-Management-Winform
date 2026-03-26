using QuanLyKhachSan.Services.Interfaces;
using QuanLyKhachSan.Services.RequestHandlers.Dtos;
using QuanLyKhachSan.Services.RequestHandlers.Interfaces;
using QuanLyKhachSan.Services.RequestHandlers.Results;

namespace QuanLyKhachSan.Services.RequestHandlers
{
    /// <summary>
    /// Handler xử lý yêu cầu làm mới danh sách khách hàng
    /// Không phụ thuộc vào UI layer
    /// </summary>
    public class RefreshCustomerListRequestHandler : IRefreshCustomerListRequestHandler
    {
        private readonly ICustomerService _customerService;

        public RefreshCustomerListRequestHandler(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        /// <summary>
        /// Xử lý yêu cầu làm mới danh sách khách hàng
        /// </summary>
        public async Task<RefreshCustomerListResult> HandleAsync(RefreshCustomerListRequest request)
        {
            try
            {
                // Validate request
                if (request == null)
                    return RefreshCustomerListResult.FailureResult(
                        "Yêu cầu không hợp lệ",
                        "INVALID_REQUEST"
                    );

                // Load customers based on refresh type
                var customers = await LoadCustomersAsync(request.Type);

                // Return result
                return RefreshCustomerListResult.SuccessResult(
                    customers.Count(),
                    "Dữ liệu đã được làm mới"
                );
            }
            catch (InvalidOperationException ex)
            {
                return RefreshCustomerListResult.FailureResult(
                    ex.Message,
                    "OPERATION_ERROR"
                );
            }
            catch (Exception ex)
            {
                return RefreshCustomerListResult.FailureResult(
                    $"Lỗi hệ thống: {ex.Message}",
                    "SYSTEM_ERROR"
                );
            }
        }

        /// <summary>
        /// Tải danh sách khách hàng dựa trên loại làm mới
        /// </summary>
        private async Task<IEnumerable<Models.Customer>> LoadCustomersAsync(RefreshType refreshType)
        {
            try
            {
                if (_customerService == null)
                    throw new InvalidOperationException("ICustomerService chưa được khởi tạo");

                var customers = await _customerService.GetAllCustomersAsync();

                if (customers == null)
                    return Enumerable.Empty<Models.Customer>();

                // Filter out deleted customers
                var activeCustomers = customers.Where(c => c.IsDeleted == 0);

                return activeCustomers.OrderBy(c => c.Name).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Lỗi khi tải danh sách khách hàng: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Lấy danh sách khách hàng hiện tại
        /// </summary>
        public async Task<IEnumerable<Models.Customer>> GetCustomersAsync()
        {
            return await LoadCustomersAsync(RefreshType.All);
        }
    }
}
