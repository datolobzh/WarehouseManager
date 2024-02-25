using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public sealed class OperationSellModel : OperationModel, IEntityModel
{
    public int CustomerId { get; set; }
}

