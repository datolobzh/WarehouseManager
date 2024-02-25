using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class ContractorConfiguration : IEntityTypeConfiguration<Contractor>
{
    public void Configure(EntityTypeBuilder<Contractor> builder)
    {
        builder.Property(c => c.FirstName)
            .HasColumnType("nvarchar")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(c => c.LastName)
            .HasColumnType("nvarchar")
            .HasMaxLength(30)
            .IsRequired();
    }
}
