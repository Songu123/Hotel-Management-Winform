using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace QuanLyKhachSan.Data
{
    public class HotelDbContextFactory : IDesignTimeDbContextFactory<HotelDbContext>
    {
        public HotelDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HotelDbContext>();

            // Connection string SQL Server
            optionsBuilder.UseSqlServer("Server=.;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

            return new HotelDbContext(optionsBuilder.Options);
        }
    }
}