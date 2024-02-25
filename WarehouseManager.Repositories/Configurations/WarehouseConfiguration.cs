using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
{
    public void Configure(EntityTypeBuilder<Warehouse> builder)
    {
        builder.Property(w => w.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(w => w.Phone)
            .HasColumnType("varchar")
            .HasMaxLength(15)
            .IsRequired();

        builder.Property(w => w.Address)
            .HasColumnType("nvarchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(w => w.Description)
            .HasColumnType("nvarchar")
            .HasMaxLength(255);

        builder.HasOne(w => w.City)
            .WithMany(w => w.Warehouse)
            .HasForeignKey(w => w.CityId);

        builder.HasIndex(u => new { u.Address, u.Phone })
            .IsUnique();
    }
}
