using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class CountryRepository : RepositoryBase<Country>, ICountryRepository
{
    public CountryRepository(WarehouseDbContext context) : base(context) { }
}
