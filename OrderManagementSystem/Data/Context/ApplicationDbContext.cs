using Microsoft.EntityFrameworkCore;
using OrderManagementSystem.Data.Model;

namespace OrderManagementSystem.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>()
                .ToTable("tb_Product")
                .HasKey(o => o.ProductId);

            modelBuilder.Entity<CustomerModel>()
                    .ToTable("tb_Customer")
                    .HasKey(o => o.CustomerId);
        }
    }
}
