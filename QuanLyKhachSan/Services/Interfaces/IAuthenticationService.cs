using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Services.Interfaces
{
    /// <summary>
    /// Interface cho dịch vụ xác thực người dùng
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Xác thực người dùng dựa trên tên đăng nhập và mật khẩu
        /// </summary>
        /// <param name="username">Tên đăng nhập</param>
        /// <param name="password">Mật khẩu</param>
        /// <returns>Đối tượng Account nếu thành công, null nếu thất bại</returns>
        Task<Account?> AuthenticateAsync(string username, string password);

        /// <summary>
        /// Lấy thông tin tài khoản theo tên đăng nhập
        /// </summary>
        Task<Account?> GetAccountAsync(string username);

        /// <summary>
        /// Kiểm tra xem tài khoản có hoạt động hay không
        /// </summary>
        Task<bool> IsAccountActiveAsync(string username);

        /// <summary>
        /// Lấy thông tin chi tiết của tài khoản (bao gồm nhân viên và quyền hạn)
        /// </summary>
        Task<(Account? account, Employee? employee, Role? role)> GetAccountDetailsAsync(string username);
    }
}
