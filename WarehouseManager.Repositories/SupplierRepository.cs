using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
{
    public SupplierRepository(WarehouseDbContext context) : base(context) { }
}

