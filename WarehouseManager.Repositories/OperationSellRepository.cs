using System.Runtime.CompilerServices;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

[assembly: InternalsVisibleTo("WarehouseManager.Tests")]

namespace WarehouseManager.Repositories;

internal class OperationSellRepository : RepositoryBase<OperationSell>, IOperationSellRepository
{
    public OperationSellRepository(WarehouseDbContext context) : base(context)
    {
    }
}
