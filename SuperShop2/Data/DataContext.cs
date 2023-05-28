using Microsoft.EntityFrameworkCore;
using SuperShop2.Data.Entities;

namespace SuperShop2.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
