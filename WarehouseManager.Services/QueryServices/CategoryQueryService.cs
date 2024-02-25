using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class CategoryQueryService : BaseQueryService<CategoryModel, Category>, ICategoryQuery
{
    protected override IRepositoryBase<Category> Repository() => _unitOfWork.CategoryRepository;

    public CategoryQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override CategoryModel GetById(int id) => base.GetById(id);

    public override IQueryable<CategoryModel> Set(Expression<Func<Category, bool>> predicate) => base.Set(predicate);

    public override IEnumerable<CategoryModel> Set() => base.Set();

}