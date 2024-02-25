using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class OperationConfiguration : IEntityTypeConfiguration<Operation>
{
    public void Configure(EntityTypeBuilder<Operation> builder)
    {
        builder.ToTable("Operation");

        builder.Property(o => o.Quantity).IsRequired();

        builder.Property(o => o.Date)
            .HasColumnType("datetime")
            .HasDefaultValueSql("GETDATE()");

        builder.HasOne(o => o.Product)
            .WithMany(p => p.Operations)
            .HasForeignKey(o => o.ProductId);

        builder.HasOne(o => o.Warehouse)
            .WithMany(w => w.Operations)
            .HasForeignKey(o => o.WarehouseId);

        builder.HasOne(o => o.User)
            .WithMany(u => u.Operations)
            .HasForeignKey(o => o.UserId);
    }
}