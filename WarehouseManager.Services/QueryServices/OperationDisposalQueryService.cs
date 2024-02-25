using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class OperationDisposalQueryService : BaseQueryService<OperationDisposalModel, OperationDisposal>, IOperationDisposalQuery
{
    public OperationDisposalQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<OperationDisposal> Repository() => _unitOfWork.OperationDisposalRepository;

    public override IQueryable<OperationDisposalModel> Set(Expression<Func<OperationDisposal, bool>> predicate) => base.Set(predicate);

    public override IEnumerable<OperationDisposalModel> Set() => base.Set();

    public override OperationDisposalModel GetById(int id) => base.GetById(id);

}
