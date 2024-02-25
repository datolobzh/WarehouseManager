using WarehouseManager.DTO.Enumerations;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public sealed class Permission : IEntity, IDeletable
{
    public int Id { get; set; }
    public PermissionType Type { get; set; }
    public string? Description { get; set; }
    public bool IsDeleted { get; set; }

    public ICollection<UserPermission>? UserPermissions { get; set; }
}