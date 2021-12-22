using Microsoft.EntityFrameworkCore;

namespace FavoriteRestaurants.Models
{
  public class FavoriteRestaurantsContext : DbContext
  {
    public DbSet<Cuisine> Cuisine { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    public FavoriteRestaurantsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}