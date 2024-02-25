using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class OperationSellQueryService : BaseQueryService<OperationSellModel,OperationSell>, IOperationSellQuery
{
    protected override IRepositoryBase<OperationSell> Repository() => _unitOfWork.OperationSellRepository;

    public OperationSellQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override IQueryable<OperationSellModel> Set(Expression<Func<OperationSell, bool>> predicate) => base.Set(predicate);

    public override IEnumerable<OperationSellModel> Set() => base.Set();

    public override OperationSellModel GetById(int id) => base.GetById(id);
}
