using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Repositories.Implementations;
using QuanLyKhachSan.Repositories.Interfaces;
using QuanLyKhachSan.Services.Implementations;
using QuanLyKhachSan.Services.Interfaces;

namespace QuanLyKhachSan.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHotelManagementServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<HotelDbContext>(options =>
    options.UseSqlServer(connectionString,
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.MigrationsAssembly(typeof(HotelDbContext).Assembly.FullName);
        }));

            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();

            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IInvoiceService, InvoiceService>();

            return services;
        }

        public static async Task InitializeDatabaseAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<HotelDbContext>();

            await dbContext.Database.EnsureCreatedAsync();

            HotelDbSeeder.SeedDatabase(dbContext);
        }
    }
}
