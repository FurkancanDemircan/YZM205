using Microsoft.EntityFrameworkCore;
using Week11.Models;

namespace Week11.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Park> Parks { get; set; }
        public DbSet<NationalPark> NationalParks { get; set; }
        public DbSet<CityPark> CityParks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Park>()
                .HasDiscriminator<string>("ParkName")
                .HasValue<CityPark>("CityPark")
                .HasValue<NationalPark>("NationalPark");
        }
    }
}
