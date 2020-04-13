using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Bingo", Species = "Chihuahua", Age = 2, Gender = "Male" },
              new Animal { AnimalId = 2, Name = "Sparta", Species = "Bengal Cat", Age = 4, Gender = "Male" }
          );
    }
  }
}