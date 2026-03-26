namespace QuanLyKhachSan.Services.RequestHandlers.Results
{
   /// <summary>
    /// Kết quả trả về từ xử lý yêu cầu reset tiêu chí tìm kiếm
  /// </summary>
    public class ResetSearchCriteriaResult
    {
        /// <summary>
      /// Trạng thái thành công
   /// </summary>
    public bool Success { get; set; }

      /// <summary>
     /// Thông báo
      /// </summary>
        public string Message { get; set; } = string.Empty;

      /// <summary>
  /// Mã lỗi
        /// </summary>
        public string? ErrorCode { get; set; }

     /// <summary>
 /// Tạo result thành công
     /// </summary>
     public static ResetSearchCriteriaResult SuccessResult(string message = "Tiêu chí tìm kiếm đã được reset")
     {
   return new ResetSearchCriteriaResult
  {
   Success = true,
         Message = message
      };
        }

        /// <summary>
        /// Tạo result thất bại
      /// </summary>
   public static ResetSearchCriteriaResult FailureResult(string message, string errorCode = "RESET_FAILED")
     {
   return new ResetSearchCriteriaResult
           {
      Success = false,
         Message = message,
       ErrorCode = errorCode
   };
        }
    }
}
