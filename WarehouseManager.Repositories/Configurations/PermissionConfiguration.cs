using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.Property(p => p.Type)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasColumnType("varchar")
            .HasMaxLength(255);
    }
}
