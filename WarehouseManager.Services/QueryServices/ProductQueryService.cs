using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class ProductQueryService : BaseQueryService<ProductModel, Product>, IProductQuery
{
    public ProductQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<Product> Repository() => _unitOfWork.ProductRepository;

    public override ProductModel GetById(int id) => base.GetById(id);

    public override IQueryable<ProductModel> Set(Expression<Func<Product, bool>> predicate) => base.Set(predicate);

    public override IEnumerable<ProductModel> Set() => base.Set();

}
