using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public sealed class OperationPurchaseModel : OperationModel, IEntityModel
{
    public int SupplierId { get; set; }
    public int WarehouseToId { get; set; }
}

