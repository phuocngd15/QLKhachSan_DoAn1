using HappyHotel.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyHotel.Data
{
    public class HappyHotelDbContext:DbContext
    {
        public HappyHotelDbContext(DbContextOptions<HappyHotelDbContext> options)
            : base(options)
        {
        }
        public DbSet<Account> SystemAccount { get; set; }

    }
}
