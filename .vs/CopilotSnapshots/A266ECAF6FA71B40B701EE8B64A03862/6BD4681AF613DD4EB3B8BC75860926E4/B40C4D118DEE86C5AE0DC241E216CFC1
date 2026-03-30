using Microsoft.Extensions.DependencyInjection;
using QuanLyKhachSan.Configuration;
using QuanLyKhachSan.Services.Interfaces;
using QuanLyKhachSan.UI;

namespace QuanLyKhachSan
{
    internal static class Program
    {
        /// <summary>
        /// Static service provider for application-wide access
        /// </summary>
        public static IServiceProvider Services { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Cấu hình Dependency Injection
            var services = new ServiceCollection();

            // Connection string
            string connectionString = "Server=.;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;";

            services.AddHotelManagementServices(connectionString);

            // Đăng ký MainForm
            services.AddScoped<MainForm>();

            var serviceProvider = services.BuildServiceProvider();
            Services = serviceProvider;

            // Khởi tạo database
            ServiceCollectionExtensions.InitializeDatabaseAsync(serviceProvider).Wait();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Sử dụng MainForm làm form chính
            var mainForm = ActivatorUtilities.CreateInstance<MainForm>(serviceProvider);
            Application.Run(mainForm);
        }
    }
}