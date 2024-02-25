using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public class ContractorModel : IEntityModel
{
    public int Id { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
}

