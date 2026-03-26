using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Services.Implementations
{
    /// <summary>
    /// Service for managing customers
    /// </summary>
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            try
            {
                return await _customerRepository.GetAllCustomersAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khách hàng", ex);
            }
        }

        public async Task<Customer?> GetCustomerAsync(string customerId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(customerId))
                    return null;

                var allCustomers = await GetAllCustomersAsync();
                return allCustomers.FirstOrDefault(c => c.CustomerId == customerId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy khách hàng {customerId}", ex);
            }
        }

        public async Task<Customer> CreateCustomerAsync(Customer customer)
        {
            try
            {
                if (customer == null)
                    throw new ArgumentNullException(nameof(customer));

                // Validate required fields
                if (string.IsNullOrWhiteSpace(customer.CustomerId))
                    throw new ArgumentException("Mã khách hàng không được để trống");

                if (string.IsNullOrWhiteSpace(customer.Name))
                    throw new ArgumentException("Tên khách hàng không được để trống");

                if (string.IsNullOrWhiteSpace(customer.PhoneNumber))
                    throw new ArgumentException("Số điện thoại không được để trống");

                // Check if customer ID already exists
                var allCustomers = await GetAllCustomersAsync();
                var existing = allCustomers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
                if (existing != null)
                    throw new InvalidOperationException($"Mã khách hàng {customer.CustomerId} đã tồn tại");

                // Check if phone number already exists
                var phoneExists = await _customerRepository.GetByPhoneNumberAsync(customer.PhoneNumber);
                if (phoneExists != null)
                    throw new InvalidOperationException($"Số điện thoại {customer.PhoneNumber} đã được sử dụng");

                // Check if ID number already exists
                if (!string.IsNullOrWhiteSpace(customer.IdNumber))
                {
                    var idExists = await _customerRepository.GetByIdNumberAsync(customer.IdNumber);
                    if (idExists != null)
                        throw new InvalidOperationException($"CMND/CCCD {customer.IdNumber} đã được sử dụng");
                }

                customer.IsDeleted = 0;
                await _customerRepository.AddAsync(customer);
                await _customerRepository.SaveChangesAsync();

                return customer;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo khách hàng mới", ex);
            }
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            try
            {
                if (customer == null)
                    throw new ArgumentNullException(nameof(customer));

                // Validate required fields
                if (string.IsNullOrWhiteSpace(customer.Name))
                    throw new ArgumentException("Tên khách hàng không được để trống");

                if (string.IsNullOrWhiteSpace(customer.PhoneNumber))
                    throw new ArgumentException("Số điện thoại không được để trống");

                var allCustomers = await GetAllCustomersAsync();
                var existing = allCustomers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
                if (existing == null)
                    throw new InvalidOperationException($"Khách hàng {customer.CustomerId} không tồn tại");

                // Check if phone number is used by another customer
                var phoneExists = await _customerRepository.GetByPhoneNumberAsync(customer.PhoneNumber);
                if (phoneExists != null && phoneExists.CustomerId != customer.CustomerId)
                    throw new InvalidOperationException($"Số điện thoại {customer.PhoneNumber} đã được sử dụng");

                // Check if ID number is used by another customer
                if (!string.IsNullOrWhiteSpace(customer.IdNumber))
                {
                    var idExists = await _customerRepository.GetByIdNumberAsync(customer.IdNumber);
                    if (idExists != null && idExists.CustomerId != customer.CustomerId)
                        throw new InvalidOperationException($"CMND/CCCD {customer.IdNumber} đã được sử dụng");
                }

                existing.Name = customer.Name;
                existing.PhoneNumber = customer.PhoneNumber;
                existing.IdNumber = customer.IdNumber;
                existing.Gender = customer.Gender;
                existing.DateOfBirth = customer.DateOfBirth;
                existing.Address = customer.Address;
                existing.Nationality = customer.Nationality;

                await _customerRepository.UpdateAsync(existing);
                await _customerRepository.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật khách hàng", ex);
            }
        }

        public async Task<bool> DeleteCustomerAsync(string customerId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(customerId))
                    throw new ArgumentException("Mã khách hàng không được để trống");

                var allCustomers = await GetAllCustomersAsync();
                var customer = allCustomers.FirstOrDefault(c => c.CustomerId == customerId);
                if (customer == null)
                    throw new InvalidOperationException($"Khách hàng {customerId} không tồn tại");

                customer.IsDeleted = 1;
                await _customerRepository.UpdateAsync(customer);
                await _customerRepository.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa khách hàng", ex);
            }
        }

        public async Task<Customer?> GetByPhoneNumberAsync(string phoneNumber)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(phoneNumber))
                    return null;

                return await _customerRepository.GetByPhoneNumberAsync(phoneNumber);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm khách hàng theo số điện thoại", ex);
            }
        }

        public async Task<Customer?> GetByIdNumberAsync(string idNumber)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idNumber))
                    return null;

                return await _customerRepository.GetByIdNumberAsync(idNumber);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm khách hàng theo CMND/CCCD", ex);
            }
        }

        public async Task<IEnumerable<Customer>> SearchByNameAsync(string name)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                    return await GetAllCustomersAsync();

                return await _customerRepository.SearchByNameAsync(name);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm khách hàng theo tên", ex);
            }
        }

        public async Task<IEnumerable<Customer>> SearchAndFilterCustomersAsync(
   string? customerId = null,
            string? name = null,
   string? idNumber = null,
         int? gender = null,
            string? phoneNumber = null,
          string? nationality = null,
string? address = null,
            DateTime? dateOfBirthFrom = null,
DateTime? dateOfBirthTo = null)
        {
            try
            {
                var allCustomers = await GetAllCustomersAsync();
                var filtered = allCustomers.AsEnumerable();

                // Filter by customer ID
                if (!string.IsNullOrWhiteSpace(customerId))
                    filtered = filtered.Where(c => c.CustomerId.Contains(customerId, StringComparison.OrdinalIgnoreCase));

                // Filter by name
                if (!string.IsNullOrWhiteSpace(name))
                    filtered = filtered.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

                // Filter by ID number
                if (!string.IsNullOrWhiteSpace(idNumber))
                    filtered = filtered.Where(c => c.IdNumber.Contains(idNumber, StringComparison.OrdinalIgnoreCase));

                // Filter by gender
                if (gender.HasValue && gender.Value >= 0)
                    filtered = filtered.Where(c => c.Gender == gender.Value);

                // Filter by phone number
                if (!string.IsNullOrWhiteSpace(phoneNumber))
                    filtered = filtered.Where(c => c.PhoneNumber.Contains(phoneNumber, StringComparison.OrdinalIgnoreCase));

                // Filter by nationality
                if (!string.IsNullOrWhiteSpace(nationality))
                    filtered = filtered.Where(c => c.Nationality.Contains(nationality, StringComparison.OrdinalIgnoreCase));

                // Filter by address
                if (!string.IsNullOrWhiteSpace(address))
                    filtered = filtered.Where(c => c.Address.Contains(address, StringComparison.OrdinalIgnoreCase));

                // Filter by date of birth
                if (dateOfBirthFrom.HasValue)
                    filtered = filtered.Where(c => c.DateOfBirth >= dateOfBirthFrom.Value);

                if (dateOfBirthTo.HasValue)
                    filtered = filtered.Where(c => c.DateOfBirth <= dateOfBirthTo.Value);

                return filtered.OrderBy(c => c.Name).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm và lọc khách hàng", ex);
            }
        }

        public async Task<bool> CustomerExistsAsync(string customerId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(customerId))
                    return false;

                var allCustomers = await GetAllCustomersAsync();
                return allCustomers.Any(c => c.CustomerId == customerId && c.IsDeleted == 0);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra khách hàng tồn tại", ex);
            }
        }

        public async Task<bool> IdNumberAlreadyExistsAsync(string idNumber, string? excludeCustomerId = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idNumber))
                    return false;

                var customer = await _customerRepository.GetByIdNumberAsync(idNumber);
                if (customer == null)
                    return false;

                if (!string.IsNullOrWhiteSpace(excludeCustomerId))
                    return customer.CustomerId != excludeCustomerId && customer.IsDeleted == 0;

                return customer.IsDeleted == 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra CMND/CCCD tồn tại", ex);
            }
        }

        public async Task<Customer?> GetCustomerWithDetailsAsync(string customerId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(customerId))
                    return null;

                return await _customerRepository.GetCustomerWithDetailsAsync(customerId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy chi tiết khách hàng", ex);
            }
        }
    }
}
