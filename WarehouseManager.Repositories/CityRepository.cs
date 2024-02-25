using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class CityRepository : RepositoryBase<City>, ICityRepository
{
    public CityRepository(WarehouseDbContext context) : base(context) { }
}
