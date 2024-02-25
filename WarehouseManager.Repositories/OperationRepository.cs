using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class OperationRepository : RepositoryBase<Operation>, IOperationRepository
{
    public OperationRepository(WarehouseDbContext context) : base(context) { }
}

