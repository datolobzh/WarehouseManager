using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public class CityModel : IEntityModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int CountryId { get; }
}


