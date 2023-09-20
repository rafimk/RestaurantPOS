using Microsoft.EntityFrameworkCore;
using RestaurantPOS.Api.Domains;

namespace RestaurantPOS.Api.Infrastructure.DAL;

public class ApplicationDbContext : DbContext
{
    public DbSet<Menu> Menus { get; set; }
    public DbSet<MenuItem> MenuItem { get; set; }
    public DbSet<RecipeItem> RecipeItems { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

}
