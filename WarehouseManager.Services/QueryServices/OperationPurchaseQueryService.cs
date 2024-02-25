using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class OperationPurchaseQueryService : BaseQueryService<OperationPurchaseModel, OperationPurchase>, IOperationPurchaseQuery
{
    public OperationPurchaseQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<OperationPurchase> Repository() => _unitOfWork.OperationPurchaseRepository;

    public override IQueryable<OperationPurchaseModel> Set(Expression<Func<OperationPurchase, bool>> predicate) => base.Set(predicate);

    public override IEnumerable<OperationPurchaseModel> Set() => base.Set();

    public override OperationPurchaseModel GetById(int id) => base.GetById(id);

}
