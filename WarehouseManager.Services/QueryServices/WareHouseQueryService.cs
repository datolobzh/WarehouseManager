using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Services.QueryServices;

public class WareHouseQueryService : BaseQueryService<WarehouseModel, Warehouse>
{
    protected override IRepositoryBase<Warehouse> Repository() => _unitOfWork.WarehouseRepository;

    public WareHouseQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override IQueryable<WarehouseModel> Set(Expression<Func<Warehouse, bool>> predicate) => base.Set(predicate);    

    public override IEnumerable<WarehouseModel> Set() => base.Set();

    public override WarehouseModel GetById(int id) => base.GetById(id);
}
 