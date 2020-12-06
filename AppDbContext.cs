using Korelskiy.ModelsForGunShop;
using Microsoft.EntityFrameworkCore;

namespace Korelskiy.GunShopASP.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
