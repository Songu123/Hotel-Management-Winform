namespace QuanLyKhachSan.Services.RequestHandlers.Dtos
{
    /// <summary>
    /// DTO chứa tiêu chí tìm kiếm để reset
    /// </summary>
    public class ResetSearchCriteriaRequest
    {
        /// <summary>
        /// Flag để reset tìm kiếm
    /// </summary>
    public bool ResetAll { get; set; } = true;
}
}
