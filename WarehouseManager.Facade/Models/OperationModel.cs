using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public abstract class OperationModel : IEntityModel
{
    public int Id { get; set; }
    public int WarehouseId { get; set; }
    public ushort Quantity { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
}
