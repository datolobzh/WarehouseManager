using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public class UserModel : IEntityModel
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public int EmployeeId { get; set; }
}


