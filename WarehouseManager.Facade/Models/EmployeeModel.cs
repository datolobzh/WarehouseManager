using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public class EmployeeModel : IEntityModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string IdentityNumber { get; set; } = null!;
    public string? Description { get; set; }
}

