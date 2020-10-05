using Microsoft.EntityFrameworkCore;
using SkiNet.API.Entities;

namespace SkiNet.API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
    }
}