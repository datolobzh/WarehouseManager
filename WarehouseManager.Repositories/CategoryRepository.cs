using System.Runtime.CompilerServices;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(WarehouseDbContext context) : base(context) { }
}
