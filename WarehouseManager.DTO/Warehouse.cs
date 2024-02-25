using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public sealed class Warehouse : IEntity, IDeletable
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsDeleted { get; set; }

    public int CityId { get; set; }
    public City? City { get; set; }
    public ICollection<Operation>? Operations { get; set; }
}

