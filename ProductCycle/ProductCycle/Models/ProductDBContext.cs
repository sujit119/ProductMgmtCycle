using Microsoft.EntityFrameworkCore;

namespace ProductCycle.Models
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> dbContextOptions):base(dbContextOptions) 
        {            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.ProductId);
            modelBuilder.Entity<Product>().Property(e => e.ProductId).ValueGeneratedNever();
        }
    }
}
