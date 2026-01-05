using Microsoft.EntityFrameworkCore;
using Products.Models;

namespace Products.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Mouse", Price = 19.99f, Stock = 120m },
            new Product { Id = 2, Name = "Keyboard", Price = 49.50f, Stock = 75m },
            new Product { Id = 3, Name = "Monitor 24\"", Price = 159.90f, Stock = 18m },
            new Product { Id = 4, Name = "USB-C Cable", Price = 9.99f, Stock = 300m },
            new Product { Id = 5, Name = "Headset", Price = 79.00f, Stock = 42m }
        );
        }
    }
}
