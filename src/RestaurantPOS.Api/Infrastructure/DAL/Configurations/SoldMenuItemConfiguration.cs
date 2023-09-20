using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RestaurantPOS.Api.Domains;

namespace RestaurantPOS.Api.Infrastructure.DAL.Configurations;

public class SoldMenuItemConfiguration : IEntityTypeConfiguration<SoldMenuItem>
{
    public void Configure(EntityTypeBuilder<SoldMenuItem> builder)
    {
        builder.HasKey(sm => sm.SoldMenuItemId);

        // Configure the many-to-one relationship between SoldMenuItem and MenuItem
        builder.HasOne(sm => sm.MenuItem)
            .WithMany(mi => mi.SoldItems)
            .HasForeignKey(sm => sm.MenuItemId);
    }
}