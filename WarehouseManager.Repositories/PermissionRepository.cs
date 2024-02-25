using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class PermissionRepository : RepositoryBase<Permission>, IPermissionRepository
{
    public PermissionRepository(WarehouseDbContext context) : base(context) { }
}
