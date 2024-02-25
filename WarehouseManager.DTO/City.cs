using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public sealed class City : IEntity, IDeletable
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsDeleted { get; set; }

    public int CountryId { get; set; }
    public Country? Country { get; set; }
    public ICollection<Warehouse>? Warehouse { get; set; }
}
