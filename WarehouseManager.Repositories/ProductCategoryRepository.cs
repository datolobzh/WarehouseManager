using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class ProductCategoryRepository : JunctionRepositoryBase<ProductCategory>, IProductCategoryRepository
{
    public ProductCategoryRepository(WarehouseDbContext context) : base(context)
    {
    }
}
