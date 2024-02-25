using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class OperationPurchaseRepository : RepositoryBase<OperationPurchase>, IOperationPurchaseRepository
{
    public OperationPurchaseRepository(WarehouseDbContext context) : base(context)
    {
    }
}
