using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public abstract class Contractor : IEntity, IDeletable
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public bool IsDeleted { get; set; }
}