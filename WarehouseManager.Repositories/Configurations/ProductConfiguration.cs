using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(50)
            .IsRequired(false);

        builder.HasIndex(p => p.Name)
            .IsUnique();

        builder.Property(p => p.Description)
            .HasColumnType("nvarchar")
            .HasMaxLength(255);

        builder.Property(p => p.UnitPrice)
            .HasColumnType("money");

        builder.Property(p => p.SellPrice)
            .HasColumnType("money");
    }
}
