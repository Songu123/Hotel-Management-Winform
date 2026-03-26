namespace QuanLyKhachSan.Services.RequestHandlers.Results
{
 /// <summary>
    /// Kết quả trả về từ xử lý yêu cầu tạo khách hàng
    /// </summary>
public class CustomerCreateResult
    {
        /// <summary>
        /// Trạng thái thành công
        /// </summary>
     public bool Success { get; set; }

        /// <summary>
        /// Mã khách hàng được tạo
   /// </summary>
        public string CustomerId { get; set; } = string.Empty;

        /// <summary>
  /// Thông báo (lỗi hoặc thành công)
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Mã lỗi (nếu có)
        /// </summary>
 public string? ErrorCode { get; set; }

        /// <summary>
        /// Chi tiết lỗi
        /// </summary>
    public List<ValidationError> Errors { get; set; } = new();

        /// <summary>
        /// Tạo result thành công
        /// </summary>
      public static CustomerCreateResult SuccessResult(string customerId, string message = "Thêm khách hàng thành công")
        {
       return new CustomerCreateResult
 {
         Success = true,
           CustomerId = customerId,
          Message = message
    };
        }

      /// <summary>
        /// Tạo result thất bại
     /// </summary>
        public static CustomerCreateResult FailureResult(string message, string errorCode = "CREATE_FAILED", params ValidationError[] errors)
  {
            return new CustomerCreateResult
     {
    Success = false,
    Message = message,
                ErrorCode = errorCode,
           Errors = errors.ToList()
            };
        }

        /// <summary>
    /// Tạo result validation failed
        /// </summary>
        public static CustomerCreateResult ValidationFailureResult(params ValidationError[] errors)
    {
       return new CustomerCreateResult
       {
    Success = false,
Message = "Dữ liệu không hợp lệ",
        ErrorCode = "VALIDATION_FAILED",
         Errors = errors.ToList()
          };
        }
    }

    /// <summary>
    /// Lỗi validation
    /// </summary>
    public class ValidationError
    {
        /// <summary>
 /// Tên field
        /// </summary>
        public string Field { get; set; } = string.Empty;

  /// <summary>
        /// Thông báo lỗi
        /// </summary>
        public string Message { get; set; } = string.Empty;

    public ValidationError(string field, string message)
   {
        Field = field;
            Message = message;
        }
    }
}
