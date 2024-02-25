using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.Property(c => c.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.HasMany(c => c.Cities)
            .WithOne(c => c.Country)
            .HasForeignKey(c => c.CountryId);

        builder.HasIndex(c => c.Name)
            .IsUnique();
    }
}
