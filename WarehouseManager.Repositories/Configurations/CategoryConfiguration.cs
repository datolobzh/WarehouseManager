using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(c => c.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(c => c.Name)
            .IsUnique();

        builder.Property(c => c.Description)
            .HasColumnType("nvarchar")
            .HasMaxLength(255);

        builder.Property(c => c.CreateDate)
            .HasColumnType("datetime")
            .HasDefaultValueSql("GETDATE()");
    }
}
