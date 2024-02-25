using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class OperationDisposalRepository : RepositoryBase<OperationDisposal>, IOperationDisposalRepository
{
    public OperationDisposalRepository(WarehouseDbContext context) : base(context)
    {
    }
}
