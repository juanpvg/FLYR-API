using Microsoft.EntityFrameworkCore;

namespace TripsDb.Models
{
    public class TripsDbContext : DbContext
    {
        public TripsDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Transport> Transport { get; set; }
        public DbSet<Journey> Journey { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Journey>().ToTable("Journey");
           modelBuilder.Entity<Transport>().ToTable("Transport");
           modelBuilder.Entity<Flight>().ToTable("Flight");
        }
    }
}
