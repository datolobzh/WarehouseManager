using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class UserPermissionConfiguration : IEntityTypeConfiguration<UserPermission>
{
    public void Configure(EntityTypeBuilder<UserPermission> builder)
    {
        builder.HasKey(pk => new { pk.UserId, pk.PermissionId });

        builder.HasOne(u => u.User)
               .WithMany(up => up.UserPermissions)
               .HasForeignKey(u => u.UserId);

        builder.HasOne(p => p.Permission)
               .WithMany(pr => pr.UserPermissions)
               .HasForeignKey(pi => pi.PermissionId);
    }
}
