using QuanLyKhachSan.Services.RequestHandlers.Dtos;
using QuanLyKhachSan.Services.RequestHandlers.Results;

namespace QuanLyKhachSan.Services.RequestHandlers
{
    /// <summary>
    /// Handler xử lý yêu cầu reset tiêu chí tìm kiếm
    /// Không phụ thuộc vào UI layer
    /// </summary>
    public class ResetSearchCriteriaRequestHandler
    {
        public ResetSearchCriteriaRequestHandler()
        {
  }

        /// <summary>
        /// Xử lý yêu cầu reset tiêu chí tìm kiếm
        /// </summary>
 public Task<ResetSearchCriteriaResult> HandleAsync(ResetSearchCriteriaRequest request)
        {
            try
            {
  // Validate request
   if (request == null)
      return Task.FromResult(ResetSearchCriteriaResult.FailureResult(
          "Yêu cầu không hợp lệ",
         "INVALID_REQUEST"
          ));

       // Reset logic
         if (request.ResetAll)
    {
          return Task.FromResult(ResetSearchCriteriaResult.SuccessResult(
     "Tiêu chí tìm kiếm đã được reset"
    ));
 }

     return Task.FromResult(ResetSearchCriteriaResult.SuccessResult());
  }
            catch (Exception ex)
            {
       return Task.FromResult(ResetSearchCriteriaResult.FailureResult(
    $"Lỗi hệ thống: {ex.Message}",
         "SYSTEM_ERROR"
       ));
    }
        }
  }
}
