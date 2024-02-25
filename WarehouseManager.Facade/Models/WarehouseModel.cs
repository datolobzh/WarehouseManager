using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public class WarehouseModel : IEntityModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? Description { get; set; }
    public int CityId { get; set; }
}
