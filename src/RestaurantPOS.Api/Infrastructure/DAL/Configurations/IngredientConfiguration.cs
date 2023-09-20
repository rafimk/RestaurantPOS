using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantPOS.Api.Domains;

namespace RestaurantPOS.Api.Infrastructure.DAL.Configurations;

public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
{
    public void Configure(EntityTypeBuilder<Ingredient> builder)
    {
        builder.Property(x => x.Unit).HasConversion<string>();

        builder.HasKey(i => i.IngredientId);

        // Configure the one-to-many relationship between Ingredient and RecipeItem
        builder.HasMany(i => i.Recipes)
            .WithOne(ri => ri.Ingredient)
            .HasForeignKey(ri => ri.IngredientId);
    }
}
