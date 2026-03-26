namespace QuanLyKhachSan.Services.RequestHandlers.Dtos
{
    /// <summary>
    /// DTO chứa dữ liệu yêu cầu tạo khách hàng mới
    /// </summary>
    public class CustomerCreateRequest
    {
        /// <summary>
        /// Mã khách hàng (auto-generated)
        /// </summary>
 public string CustomerId { get; set; } = string.Empty;

        /// <summary>
        /// Họ tên khách hàng (bắt buộc)
        /// </summary>
        public string Name { get; set; } = string.Empty;

   /// <summary>
        /// CMND/CCCD (tuỳ chọn)
   /// </summary>
        public string IdNumber { get; set; } = string.Empty;

        /// <summary>
        /// Giới tính (1 = Nam, 0 = Nữ)
        /// </summary>
   public int Gender { get; set; } = 1;

        /// <summary>
        /// Số điện thoại (bắt buộc)
        /// </summary>
public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Địa chỉ (tuỳ chọn)
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
   /// Quốc tịch (tuỳ chọn)
        /// </summary>
        public string Nationality { get; set; } = string.Empty;

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime DateOfBirth { get; set; } = DateTime.Now.AddYears(-18);
    }
}
