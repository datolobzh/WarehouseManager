using WarehouseManager.DTO.Enumerations;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public class PermissionModel : IEntityModel
{
    public int Id { get; set; }
    public PermissionType PermissionType { get; set; }
    public string? Description { get; set; }

}
