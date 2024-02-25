using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public sealed class User : IEntity, IDeletable
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }

    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    public ICollection<Operation>? Operations { get; set; }
    public ICollection<UserPermission>? UserPermissions { get; set; }
}