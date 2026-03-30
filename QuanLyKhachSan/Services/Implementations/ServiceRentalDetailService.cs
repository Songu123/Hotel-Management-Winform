using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Implementations;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Services.Implementations
{
    /// <summary>
    /// Service implementation cho ServiceRentalDetail
    /// </summary>
    public class ServiceRentalDetailService : IServiceRentalDetailService
    {
        private readonly ServiceRentalDetailRepository _serviceRentalDetailRepository;
        private readonly IServiceService _serviceService;

        public ServiceRentalDetailService(
            ServiceRentalDetailRepository serviceRentalDetailRepository,
            IServiceService serviceService)
        {
            _serviceRentalDetailRepository = serviceRentalDetailRepository ?? throw new ArgumentNullException(nameof(serviceRentalDetailRepository));
            _serviceService = serviceService ?? throw new ArgumentNullException(nameof(serviceService));
        }

        /// <summary>
        /// Thêm chi tiết dịch vụ thuê mới
        /// </summary>
        public async Task<bool> AddServiceRentalDetailAsync(ServiceRentalDetail serviceRentalDetail)
        {
            try
            {
                if (serviceRentalDetail == null)
                    throw new ArgumentNullException(nameof(serviceRentalDetail));

                // Validate required fields
                if (string.IsNullOrWhiteSpace(serviceRentalDetail.RentalDetailId))
                    throw new ArgumentException("Mã chi tiết thuê không được để trống");

                if (string.IsNullOrWhiteSpace(serviceRentalDetail.ServiceId))
                    throw new ArgumentException("Mã dịch vụ không được để trống");

                // Check if service exists
                var service = await _serviceService.GetServiceAsync(serviceRentalDetail.ServiceId);
                if (service == null)
                    throw new InvalidOperationException($"Dịch vụ {serviceRentalDetail.ServiceId} không tồn tại");

                await _serviceRentalDetailRepository.AddAsync(serviceRentalDetail);
                await _serviceRentalDetailRepository.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm chi tiết dịch vụ thuê", ex);
            }
        }

        /// <summary>
        /// Thêm nhiều chi tiết dịch vụ thuê
        /// </summary>
        public async Task<bool> AddServiceRentalDetailsAsync(IEnumerable<ServiceRentalDetail> serviceRentalDetails)
        {
            try
            {
                if (serviceRentalDetails == null || !serviceRentalDetails.Any())
                    throw new ArgumentException("Danh sách chi tiết dịch vụ không được để trống");

                // Validate ALL items first before adding any
                foreach (var detail in serviceRentalDetails)
                {
                    if (detail == null)
                        throw new ArgumentNullException(nameof(detail));

                    if (string.IsNullOrWhiteSpace(detail.RentalDetailId))
                        throw new ArgumentException("Mã chi tiết thuê không được để trống");

                    if (string.IsNullOrWhiteSpace(detail.ServiceId))
                        throw new ArgumentException("Mã dịch vụ không được để trống");

                    // Check if service exists
                    var service = await _serviceService.GetServiceAsync(detail.ServiceId);
                    if (service == null)
                        throw new InvalidOperationException($"Dịch vụ {detail.ServiceId} không tồn tại");
                }

                // Add all at once using AddRangeAsync
                await _serviceRentalDetailRepository.AddRangeAsync(serviceRentalDetails);
                await _serviceRentalDetailRepository.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhiều chi tiết dịch vụ thuê", ex);
            }
        }

        /// <summary>
        /// Lấy chi tiết dịch vụ thuê theo ID chi tiết thuê
        /// </summary>
        public async Task<IEnumerable<ServiceRentalDetail>> GetServiceRentalDetailsByRentalDetailIdAsync(string rentalDetailId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rentalDetailId))
                    return new List<ServiceRentalDetail>();

                var allDetails = await _serviceRentalDetailRepository.GetAllAsync();
                return allDetails.Where(s => s.RentalDetailId == rentalDetailId).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy chi tiết dịch vụ thuê", ex);
            }
        }

        /// <summary>
        /// Lấy chi tiết dịch vụ thuê theo ID dịch vụ
        /// </summary>
        public async Task<IEnumerable<ServiceRentalDetail>> GetServiceRentalDetailsByServiceIdAsync(string serviceId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(serviceId))
                    return new List<ServiceRentalDetail>();

                var allDetails = await _serviceRentalDetailRepository.GetAllAsync();
                return allDetails.Where(s => s.ServiceId == serviceId).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy chi tiết dịch vụ {serviceId}", ex);
            }
        }

        /// <summary>
        /// Cập nhật chi tiết dịch vụ thuê
        /// </summary>
        public async Task<bool> UpdateServiceRentalDetailAsync(ServiceRentalDetail serviceRentalDetail)
        {
            try
            {
                if (serviceRentalDetail == null)
                    throw new ArgumentNullException(nameof(serviceRentalDetail));

                await _serviceRentalDetailRepository.UpdateAsync(serviceRentalDetail);
                await _serviceRentalDetailRepository.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật chi tiết dịch vụ thuê", ex);
            }
        }

        /// <summary>
        /// Xóa chi tiết dịch vụ thuê
        /// </summary>
        public async Task<bool> DeleteServiceRentalDetailAsync(string rentalDetailId, string serviceId, DateTime usageDate)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rentalDetailId) || string.IsNullOrWhiteSpace(serviceId))
                    throw new ArgumentException("Mã chi tiết thuê và mã dịch vụ không được để trống");

                var allDetails = await _serviceRentalDetailRepository.GetAllAsync();
                var detail = allDetails.FirstOrDefault(s =>
              s.RentalDetailId == rentalDetailId &&
       s.ServiceId == serviceId &&
               s.UsageDate == usageDate);

                if (detail == null)
                    throw new InvalidOperationException("Chi tiết dịch vụ thuê không tồn tại");

                await _serviceRentalDetailRepository.DeleteAsync(detail);
                await _serviceRentalDetailRepository.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa chi tiết dịch vụ thuê", ex);
            }
        }

        /// <summary>
        /// Xóa tất cả chi tiết dịch vụ của một chi tiết thuê
        /// </summary>
        public async Task<bool> DeleteAllServiceRentalDetailsByRentalDetailIdAsync(string rentalDetailId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rentalDetailId))
                    throw new ArgumentException("Mã chi tiết thuê không được để trống");

                var allDetails = await _serviceRentalDetailRepository.GetAllAsync();
                var detailsToDelete = allDetails.Where(s => s.RentalDetailId == rentalDetailId).ToList();

                foreach (var detail in detailsToDelete)
                {
                    await _serviceRentalDetailRepository.DeleteAsync(detail);
                }

                await _serviceRentalDetailRepository.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa chi tiết dịch vụ thuê", ex);
            }
        }

        /// <summary>
        /// Lấy chi tiết dịch vụ thuê cùng với thông tin dịch vụ
        /// </summary>
        public async Task<IEnumerable<ServiceRentalDetail>> GetServiceRentalDetailsWithServiceAsync(string rentalDetailId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rentalDetailId))
                    return new List<ServiceRentalDetail>();

                return await GetServiceRentalDetailsByRentalDetailIdAsync(rentalDetailId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy chi tiết dịch vụ cùng thông tin", ex);
            }
        }

        /// <summary>
        /// Tính tổng tiền cho chi tiết thuê từ dịch vụ
        /// </summary>
        public async Task<int> CalculateTotalServicePriceAsync(string rentalDetailId)
        {
            try
            {
                var serviceDetails = await GetServiceRentalDetailsByRentalDetailIdAsync(rentalDetailId);
                return serviceDetails.Sum(s => s.Price * s.Quantity);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính tổng tiền dịch vụ", ex);
            }
        }
    }
}
