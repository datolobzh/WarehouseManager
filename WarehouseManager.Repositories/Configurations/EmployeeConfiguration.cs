using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.FirstName)
            .HasColumnType("nvarchar")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(e => e.LastName)
            .HasColumnType("nvarchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(e => e.IdentityNumber)
            .HasMaxLength(11)
            .IsRequired();

        builder.Property(e => e.Description)
            .HasMaxLength(255);

        builder.HasIndex(e => e.IdentityNumber)
            .IsUnique();
    }
}
