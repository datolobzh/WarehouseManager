using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public sealed class Employee : IEntity, IDeletable
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string IdentityNumber { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsDeleted { get; set; }

    public User? User { get; set; }
}