using Microsoft.EntityFrameworkCore;

namespace Animal.Models
{
  public class AnimalContext : DbContext
  {
    public AnimalContext(DbContextOptions<AnimalContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
  }
}