using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class CityQueryService : BaseQueryService<CityModel, City>, ICityQuery
{
    protected override IRepositoryBase<City> Repository() => _unitOfWork.CityRepository;

    public CityQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override CityModel GetById(int id) => base.GetById(id);

    public override IQueryable<CityModel> Set(Expression<Func<City, bool>> predicate) => base.Set(predicate);

    public override IEnumerable<CityModel> Set() => base.Set();
}
