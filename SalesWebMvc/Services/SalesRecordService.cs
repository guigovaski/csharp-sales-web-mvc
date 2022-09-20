using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Net;

namespace SalesWebMvc.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcContext _context;

        public SalesRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var query = from p in _context.SalesRecord select p;

            if (minDate.HasValue)
            {
                query = query.Where(x => x.Date >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                query = query.Where(x => x.Date <= maxDate.Value);
            }

            return await query
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderBy(x => x.Date)
                .ToListAsync();
        }
    }
}

