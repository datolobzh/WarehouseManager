using System.Runtime.CompilerServices;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

[assembly: InternalsVisibleTo("WarehouseManager.Tests")]

namespace WarehouseManager.Repositories;

internal class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(WarehouseDbContext context) : base(context) { }
}
