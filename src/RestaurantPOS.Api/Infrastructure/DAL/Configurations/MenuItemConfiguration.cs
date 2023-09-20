using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantPOS.Api.Domains;

namespace RestaurantPOS.Api.Infrastructure.DAL.Configurations;

public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
{
    public void Configure(EntityTypeBuilder<MenuItem> builder)
    {
        builder.Property(x => x.ServingType).HasConversion<string>();

        builder.HasKey(mi => mi.MenuItemId);

        // Configure the many-to-one relationship between MenuItem and Menu
        builder.HasOne(mi => mi.Menu)
            .WithMany(m => m.Items)
            .HasForeignKey(mi => mi.MenuId);

        // Configure the one-to-many relationship between MenuItem and RecipeItem
        builder.HasMany(mi => mi.Recipes)
            .WithOne(ri => ri.MenuItem)
            .HasForeignKey(ri => ri.MenuItemId);
    }
}
