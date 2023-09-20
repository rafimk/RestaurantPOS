using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantPOS.Api.Domains;

namespace RestaurantPOS.Api.Infrastructure.DAL.Configurations;

public class RecipeItemConfiguration : IEntityTypeConfiguration<RecipeItem>
{
    public void Configure(EntityTypeBuilder<RecipeItem> builder)
    {
        builder.Property(x => x.Unit).HasConversion<string>();

        builder.HasKey(ri => ri.RecipeItemId);

        // Configure the many-to-one relationship between RecipeItem and MenuItem
        builder.HasOne(ri => ri.MenuItem)
            .WithMany(mi => mi.Recipes)
            .HasForeignKey(ri => ri.MenuItemId);

        // Configure the many-to-one relationship between RecipeItem and Ingredient
        builder.HasOne(ri => ri.Ingredient)
            .WithMany(i => i.Recipes)
            .HasForeignKey(ri => ri.IngredientId);
    }
}
