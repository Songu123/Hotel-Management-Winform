using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Service interface cho ServiceRentalDetail (Chi tiết dịch vụ trong chi tiết thuê)
    /// </summary>
    public interface IServiceRentalDetailService
    {
        /// <summary>
        /// Thêm chi tiết dịch vụ thuê mới
        /// </summary>
        Task<bool> AddServiceRentalDetailAsync(ServiceRentalDetail serviceRentalDetail);

        /// <summary>
        /// Thêm nhiều chi tiết dịch vụ thuê
        /// </summary>
        Task<bool> AddServiceRentalDetailsAsync(IEnumerable<ServiceRentalDetail> serviceRentalDetails);

        /// <summary>
        /// Lấy chi tiết dịch vụ thuê theo ID chi tiết thuê
        /// </summary>
        Task<IEnumerable<ServiceRentalDetail>> GetServiceRentalDetailsByRentalDetailIdAsync(string rentalDetailId);

        /// <summary>
        /// Lấy chi tiết dịch vụ thuê theo ID dịch vụ
        /// </summary>
        Task<IEnumerable<ServiceRentalDetail>> GetServiceRentalDetailsByServiceIdAsync(string serviceId);

        /// <summary>
        /// Cập nhật chi tiết dịch vụ thuê
        /// </summary>
        Task<bool> UpdateServiceRentalDetailAsync(ServiceRentalDetail serviceRentalDetail);

        /// <summary>
        /// Xóa chi tiết dịch vụ thuê
        /// </summary>
        Task<bool> DeleteServiceRentalDetailAsync(string rentalDetailId, string serviceId, DateTime usageDate);

        /// <summary>
        /// Xóa tất cả chi tiết dịch vụ của một chi tiết thuê
        /// </summary>
        Task<bool> DeleteAllServiceRentalDetailsByRentalDetailIdAsync(string rentalDetailId);

        /// <summary>
        /// Lấy chi tiết dịch vụ thuê cùng với thông tin dịch vụ
        /// </summary>
        Task<IEnumerable<ServiceRentalDetail>> GetServiceRentalDetailsWithServiceAsync(string rentalDetailId);

        /// <summary>
        /// Tính tổng tiền cho chi tiết thuê từ dịch vụ
        /// </summary>
        Task<int> CalculateTotalServicePriceAsync(string rentalDetailId);
    }
}
