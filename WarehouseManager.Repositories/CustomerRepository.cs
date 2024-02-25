using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
{
    public CustomerRepository(WarehouseDbContext context) : base(context) { }
}
