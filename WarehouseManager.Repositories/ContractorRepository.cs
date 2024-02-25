using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class ContractorRepository : RepositoryBase<Contractor>, IContractorRepository
{
    public ContractorRepository(WarehouseDbContext context) : base(context) { }
}
