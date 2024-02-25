using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public sealed class OperationTransferModel : OperationModel, IEntityModel
{
    public int WarehouseToId { get; set; }
}
