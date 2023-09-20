using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantPOS.Api.Domains;

namespace RestaurantPOS.Api.Infrastructure.DAL.Configurations;

public class MenuConfiguration : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
        builder.HasKey(m => m.MenuId);

        // Configure the one-to-many relationship between Menu and MenuItem
        builder.HasMany(m => m.Items)
            .WithOne(mi => mi.Menu)
            .HasForeignKey(mi => mi.MenuId);
    }
}
