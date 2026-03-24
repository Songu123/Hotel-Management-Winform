using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories.Interfaces;

namespace QuanLyKhachSan.Repositories.Implementations
{
 /// <summary>
    /// Invoice Repository implementation
    /// </summary>
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
  {
  public InvoiceRepository(HotelDbContext context) : base(context)
    {
     }

        public DbContext DbContext => _context;

        public async Task<Invoice?> GetByIdAsync(string invoiceId)
      {
   return await _dbSet.FirstOrDefaultAsync(i => i.InvoiceId == invoiceId);
    }

        public async Task<IEnumerable<Invoice>> GetByRentalDetailAsync(string rentalDetailId)
        {
 return await _dbSet
     .Where(i => i.RentalDetailId == rentalDetailId)
        .OrderByDescending(i => i.PaymentDate)
         .ToListAsync();
    }

        public async Task<IEnumerable<Invoice>> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
   {
   return await _dbSet
     .Where(i => i.PaymentDate >= startDate && i.PaymentDate <= endDate)
     .Include(i => i.RentalDetail)
       .OrderByDescending(i => i.PaymentDate)
     .ToListAsync();
    }

        public async Task<IEnumerable<Invoice>> GetAllInvoicesAsync()
 {
   return await _dbSet
       .Where(i => i.IsDeleted == 0)
    .OrderByDescending(i => i.PaymentDate)
      .ToListAsync();
    }

    public async Task<decimal> GetTotalAmountAsync()
    {
    return await _dbSet
  .Where(i => i.IsDeleted == 0)
  .SumAsync(i => (decimal)(i.Discount + i.Surcharge));
    }

 public async Task<string> GenerateInvoiceNumberAsync()
       {
   var today = DateTime.Now;
      var dateString = today.ToString("yyyyMMdd");
    var lastInvoice = await _dbSet
.OrderByDescending(i => i.InvoiceId)
    .FirstOrDefaultAsync();

      var nextNumber = 1;
   if (lastInvoice != null)
     {
        nextNumber = int.Parse(lastInvoice.InvoiceId.Substring(Math.Max(0, lastInvoice.InvoiceId.Length - 3))) + 1;
    }

  return $"HĐ-{dateString}-{nextNumber:D4}";
    }
  }
}
