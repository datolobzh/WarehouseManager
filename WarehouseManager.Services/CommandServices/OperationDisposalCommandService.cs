using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class OperationDisposalCommandService : BaseCommandService<OperationDisposalModel, OperationDisposal>, IOperationDisposalCommand
{
    public OperationDisposalCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<OperationDisposal> Repository() => _unitOfWork.OperationDisposalRepository;

    public override int Insert(OperationDisposalModel model) => base.Insert(model);

    public override int Delete(int id) => base.Delete(id);

    public override void Update(int id, OperationDisposalModel model) => base.Update(id, model);

}
