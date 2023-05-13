using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductMarket.Data.Entity;

namespace ProductMarket.Data.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p=>p.ProductName).HasMaxLength(250);
        builder.Property(p=>p.Price).HasColumnType("decimal(18,2)");
    }
}
