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
              new Animal { AnimalId = 1, Name = "Maxie", Species = "German-Shepherd", Age = 5, Gender = "Male" },
              new Animal { AnimalId = 2, Name = "Anna", Species = "Showshoe", Age = 1, Gender = "Female" },
              new Animal { AnimalId = 3, Name = "Bingo", Species = "Persian Cat", Age = 2, Gender = "Male" },
              new Animal { AnimalId = 4, Name = "Chico", Species = "Bulldog", Age = 3, Gender = "Male" },
              new Animal { AnimalId = 5, Name = "Camila", Species = "Chihuahua", Age = 4, Gender = "Female" }
          );
    }
  }
}