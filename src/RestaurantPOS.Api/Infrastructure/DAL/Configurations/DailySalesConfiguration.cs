using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RestaurantPOS.Api.Domains;

namespace RestaurantPOS.Api.Infrastructure.DAL.Configurations;

public class DailySalesConfiguration : IEntityTypeConfiguration<DailySales>
{
    public void Configure(EntityTypeBuilder<DailySales> builder)
    {
        builder.HasKey(ds => ds.DailySalesId);
        builder.Property(ds => ds.Date).IsRequired();

        // Configure the one-to-many relationship between DailySales and SoldMenuItem
        builder.HasMany(ds => ds.SoldMenuItems)
            .WithOne(sm => sm.DailySales)
            .HasForeignKey(sm => sm.DailySalesId);
    }
}