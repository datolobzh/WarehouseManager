using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public class OperationTransfer : Operation, IEntityModel
{
    public int WarehouseToId { get; set; }
    public Warehouse WarehouseTo { get; set; } = null!;
}
