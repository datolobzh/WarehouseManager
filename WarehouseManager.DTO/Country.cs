using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public sealed class Country : IEntity, IDeletable
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsDeleted { get; set; }

    public ICollection<City>? Cities { get; set; }
}