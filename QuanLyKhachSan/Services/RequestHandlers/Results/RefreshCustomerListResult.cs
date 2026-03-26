namespace QuanLyKhachSan.Services.RequestHandlers.Results
{
    /// <summary>
    /// Kết quả trả về từ xử lý yêu cầu làm mới danh sách khách hàng
    /// </summary>
    public class RefreshCustomerListResult
    {
   /// <summary>
      /// Trạng thái thành công
        /// </summary>
        public bool Success { get; set; }

     /// <summary>
   /// Thông báo (lỗi hoặc thành công)
        /// </summary>
        public string Message { get; set; } = string.Empty;

      /// <summary>
      /// Mã lỗi (nếu có)
     /// </summary>
        public string? ErrorCode { get; set; }

       /// <summary>
        /// Số lượng khách hàng được tải
        /// </summary>
    public int CustomerCount { get; set; } = 0;

    /// <summary>
     /// Tạo result thành công
  /// </summary>
    public static RefreshCustomerListResult SuccessResult(int customerCount, string message = "Dữ liệu đã được làm mới")
 {
      return new RefreshCustomerListResult
 {
      Success = true,
    Message = message,
        CustomerCount = customerCount
        };
        }

     /// <summary>
 /// Tạo result thất bại
        /// </summary>
        public static RefreshCustomerListResult FailureResult(string message, string errorCode = "REFRESH_FAILED")
    {
      return new RefreshCustomerListResult
  {
         Success = false,
        Message = message,
           ErrorCode = errorCode
            };
        }
    }
}
