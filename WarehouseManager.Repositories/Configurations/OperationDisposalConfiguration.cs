using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class OperationDisposalConfiguration : IEntityTypeConfiguration<OperationDisposal>
{
    public void Configure(EntityTypeBuilder<OperationDisposal> builder)
    {
        builder.Property(d => d.Comment)
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();
    }
}
