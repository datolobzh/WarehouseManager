using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.Property(c => c.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(c => c.Name)
            .IsUnique();
    }
}
