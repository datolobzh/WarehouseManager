using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class OperationTransferQueryService : BaseQueryService<OperationTransferModel, OperationTransfer>, IOperationTransferQuery
{
    public OperationTransferQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<OperationTransfer> Repository() => _unitOfWork.OperationTransferRepository;

    public override IQueryable<OperationTransferModel> Set(Expression<Func<OperationTransfer, bool>> predicate) => base.Set(predicate);

    public override IEnumerable<OperationTransferModel> Set() => base.Set();

    public override OperationTransferModel GetById(int id) => base.GetById(id);

}
