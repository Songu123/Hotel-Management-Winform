using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Implementations;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Services.Implementations
{
    /// <summary>
    /// Service implementation cho Service (Dịch vụ)
    /// </summary>
    public class ServiceService : IServiceService
    {
     private readonly IServiceRepository _serviceRepository;

     public ServiceService(IServiceRepository serviceRepository)
        {
  _serviceRepository = serviceRepository ?? throw new ArgumentNullException(nameof(serviceRepository));
      }

      /// <summary>
   /// Lấy tất cả dịch vụ
        /// </summary>
  public async Task<IEnumerable<Service>> GetAllServicesAsync()
        {
            try
            {
           var services = await _serviceRepository.GetAllAsync();
          return services.Where(s => s.IsDeleted == 0).ToList();
        }
     catch (Exception ex)
            {
   throw new Exception("Lỗi khi lấy danh sách dịch vụ", ex);
            }
 }

    /// <summary>
        /// Lấy dịch vụ theo ID
        /// </summary>
        public async Task<Service?> GetServiceAsync(string serviceId)
        {
            try
      {
     if (string.IsNullOrWhiteSpace(serviceId))
        return null;

    var service = await (_serviceRepository as ServiceRepository).GetByIdAsyncString(serviceId);
     return service?.IsDeleted == 0 ? service : null;
}
            catch (Exception ex)
    {
         throw new Exception($"Lỗi khi lấy dịch vụ {serviceId}", ex);
       }
 }

        /// <summary>
  /// Tạo dịch vụ mới
        /// </summary>
        public async Task<Service> CreateServiceAsync(Service service)
        {
            try
            {
                if (service == null)
   throw new ArgumentNullException(nameof(service));

  if (string.IsNullOrWhiteSpace(service.ServiceId))
    throw new ArgumentException("Mã dịch vụ không được để trống");

           if (string.IsNullOrWhiteSpace(service.Name))
        throw new ArgumentException("Tên dịch vụ không được để trống");

    var existing = await (_serviceRepository as ServiceRepository).GetByIdAsyncString(service.ServiceId);
    if (existing != null && existing.IsDeleted == 0)
      throw new InvalidOperationException($"Dịch vụ {service.ServiceId} đã tồn tại");

        service.IsDeleted = 0;
           await _serviceRepository.AddAsync(service);
    await _serviceRepository.SaveChangesAsync();

       return service;
       }
            catch (Exception ex)
  {
      throw new Exception("Lỗi khi tạo dịch vụ mới", ex);
  }
        }

  /// <summary>
        /// Cập nhật dịch vụ
 /// </summary>
        public async Task<bool> UpdateServiceAsync(Service service)
     {
      try
  {
    if (service == null)
     throw new ArgumentNullException(nameof(service));

 if (string.IsNullOrWhiteSpace(service.Name))
         throw new ArgumentException("Tên dịch vụ không được để trống");

 var existing = await (_serviceRepository as ServiceRepository).GetByIdAsyncString(service.ServiceId);
    if (existing == null || existing.IsDeleted == 1)
  throw new InvalidOperationException($"Dịch vụ {service.ServiceId} không tồn tại");

     existing.Name = service.Name;
     existing.Type = service.Type;
        existing.Price = service.Price;
       existing.Image = service.Image;

 await _serviceRepository.UpdateAsync(existing);
     await _serviceRepository.SaveChangesAsync();

      return true;
     }
   catch (Exception ex)
          {
             throw new Exception("Lỗi khi cập nhật dịch vụ", ex);
      }
        }

        /// <summary>
   /// Xóa dịch vụ (soft delete)
        /// </summary>
        public async Task<bool> DeleteServiceAsync(string serviceId)
  {
      try
            {
    if (string.IsNullOrWhiteSpace(serviceId))
   throw new ArgumentException("Mã dịch vụ không được để trống");

              var service = await (_serviceRepository as ServiceRepository).GetByIdAsyncString(serviceId);
 if (service == null || service.IsDeleted == 1)
     throw new InvalidOperationException($"Dịch vụ {serviceId} không tồn tại");

service.IsDeleted = 1;
      await _serviceRepository.UpdateAsync(service);
    await _serviceRepository.SaveChangesAsync();

            return true;
  }
   catch (Exception ex)
     {
    throw new Exception("Lỗi khi xóa dịch vụ", ex);
      }
 }

    /// <summary>
        /// Tìm kiếm dịch vụ theo tên
   /// </summary>
 public async Task<IEnumerable<Service>> SearchByNameAsync(string name)
        {
   try
            {
  if (string.IsNullOrWhiteSpace(name))
    return await GetAllServicesAsync();

        var allServices = await GetAllServicesAsync();
       return allServices
        .Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
    .ToList();
  }
 catch (Exception ex)
         {
     throw new Exception("Lỗi khi tìm kiếm dịch vụ theo tên", ex);
    }
        }

        /// <summary>
   /// Lọc dịch vụ theo loại
        /// </summary>
        public async Task<IEnumerable<Service>> FilterByTypeAsync(string type)
 {
        try
  {
     if (string.IsNullOrWhiteSpace(type))
    return await GetAllServicesAsync();

      var allServices = await GetAllServicesAsync();
          return allServices
       .Where(s => s.Type.Contains(type, StringComparison.OrdinalIgnoreCase))
 .ToList();
       }
    catch (Exception ex)
   {
    throw new Exception("Lỗi khi lọc dịch vụ theo loại", ex);
       }
     }

        /// <summary>
        /// Kiểm tra dịch vụ có tồn tại hay không
        /// </summary>
        public async Task<bool> ServiceExistsAsync(string serviceId)
    {
         try
    {
      if (string.IsNullOrWhiteSpace(serviceId))
 return false;

var service = await (_serviceRepository as ServiceRepository).GetByIdAsyncString(serviceId);
    return service != null && service.IsDeleted == 0;
        }
  catch (Exception ex)
  {
 throw new Exception("Lỗi khi kiểm tra dịch vụ tồn tại", ex);
      }
        }
    }
}
