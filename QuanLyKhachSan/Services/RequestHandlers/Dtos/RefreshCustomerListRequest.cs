namespace QuanLyKhachSan.Services.RequestHandlers.Dtos
{
  /// <summary>
    /// DTO chứa dữ liệu yêu cầu làm mới danh sách khách hàng
    /// </summary>
    public class RefreshCustomerListRequest
    {
        /// <summary>
        /// Loại làm mới (All = tất cả, SearchCriteria = dựa trên tiêu chí tìm kiếm)
        /// </summary>
public RefreshType Type { get; set; } = RefreshType.All;
    }

    /// <summary>
    /// Loại làm mới
 /// </summary>
    public enum RefreshType
    {
 /// <summary>
   /// Làm mới toàn bộ danh sách
  /// </summary>
        All = 0,

      /// <summary>
        /// Làm mới theo tiêu chí tìm kiếm hiện tại
        /// </summary>
        SearchCriteria = 1
    }
}
