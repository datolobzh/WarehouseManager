using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class CountryQueryService : BaseQueryService<CountryModel, Country>, ICountryQuery
{
    protected override IRepositoryBase<Country> Repository() => _unitOfWork.CountryRepository;

    public CountryQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override CountryModel GetById(int id) => base.GetById(id);

    public override IQueryable<CountryModel> Set(Expression<Func<Country, bool>> predicate) => base.Set(predicate);

    public override IEnumerable<CountryModel> Set() => base.Set();
}