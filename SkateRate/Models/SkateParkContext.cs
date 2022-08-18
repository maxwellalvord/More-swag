using Microsoft.EntityFrameworkCore;

namespace SkateRate.Models
{
    public class SkateRateContext : DbContext
    {
        public SkateRateContext(DbContextOptions<SkateRateContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
              .HasData(
                  new Park { ParkId = 1, Name = "Matilda", Location = "Woolly Mammoth", Rating = 7, Nickname = "Female" },
                  new Park { ParkId = 2, Name = "Rexie", Location = "Dinosaur", Rating = 10, Nickname = "Female" },
                  new Park { ParkId = 3, Name = "Matilda", Location = "Dinosaur", Rating = 2, Nickname = "Female" },
                  new Park { ParkId = 4, Name = "Pip", Location = "Shark", Rating = 4, Nickname = "Male" },
                  new Park { ParkId = 5, Name = "Bartholomew", Location = "Dinosaur", Rating = 22, Nickname = "Male" }
              );
        }
        public DbSet<Park> Parks { get; set; }
    }
}