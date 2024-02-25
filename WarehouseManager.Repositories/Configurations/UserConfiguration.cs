using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;
using WarehouseManager.Facade;

namespace WarehouseManager.Repositories.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Username)
            .HasColumnType("varchar")
            .HasMaxLength(15)
            .IsRequired();

        builder.Property(u => u.Password)
            .IsRequired()
            .HasColumnType("varbinary(MAX)")
            .HasConversion(
            p => p.HashData(),
            p => p);

        builder.Property(u => u.IsActive)
       .HasDefaultValue(true);

        builder.HasIndex(u => u.Username)
            .IsUnique();

        builder.HasOne(u => u.Employee)
            .WithOne(e => e.User)
            .HasForeignKey<User>(u => u.EmployeeId);
    }
}
