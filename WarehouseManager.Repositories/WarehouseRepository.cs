using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class WarehouseRepository : RepositoryBase<Warehouse>, IWarehouseRepository
{
    public WarehouseRepository(WarehouseDbContext context) : base(context) { }
}

