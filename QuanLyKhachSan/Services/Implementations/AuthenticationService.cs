using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Services.Implementations
{
    /// <summary>
    /// Service implementation cho xác thực người dùng
    /// </summary>
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HotelDbContext _context;

        public AuthenticationService(HotelDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Xác thực người dùng
        /// </summary>
        public async Task<Account?> AuthenticateAsync(string username, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                    return null;

                // Tìm tài khoản trong database
                var account = await _context.Accounts
        .FirstOrDefaultAsync(a => a.Username == username && a.IsDeleted == 0);

                if (account == null)
                    return null;

                // Kiểm tra mật khẩu (so sánh trực tiếp - trong thực tế nên hash)
                if (account.Password != password)
                    return null;

                // Kiểm tra trạng thái tài khoản (Status = 0 là hoạt động)
                if (account.Status == 0)
                    return null;

                return account;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xác thực tài khoản", ex);
            }
        }

        /// <summary>
        /// Lấy thông tin tài khoản
        /// </summary>
        public async Task<Account?> GetAccountAsync(string username)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                    return null;

                var account = await _context.Accounts
          .FirstOrDefaultAsync(a => a.Username == username && a.IsDeleted == 0);

                return account;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin tài khoản", ex);
            }
        }

        /// <summary>
        /// Kiểm tra tài khoản có hoạt động
        /// </summary>
        public async Task<bool> IsAccountActiveAsync(string username)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                    return false;

                var account = await _context.Accounts
              .FirstOrDefaultAsync(a => a.Username == username);

                if (account == null || account.IsDeleted == 1)
                    return false;

                return account.Status == 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra trạng thái tài khoản", ex);
            }
        }

        /// <summary>
        /// Lấy thông tin chi tiết tài khoản
        /// </summary>
        public async Task<(Account? account, Employee? employee, Role? role)> GetAccountDetailsAsync(string username)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                    return (null, null, null);

                var account = await _context.Accounts
             .Include(a => a.Employee)
            .Include(a => a.Role)
                 .FirstOrDefaultAsync(a => a.Username == username && a.IsDeleted == 0);

                if (account == null)
                    return (null, null, null);

                return (account, account.Employee, account.Role);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy chi tiết tài khoản", ex);
            }
        }
    }
}
