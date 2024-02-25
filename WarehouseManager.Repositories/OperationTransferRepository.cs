using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class OperationTransferRepository : RepositoryBase<OperationTransfer>, IOperationTransferRepository
{
    public OperationTransferRepository(WarehouseDbContext context) : base(context)
    {
    }
}
