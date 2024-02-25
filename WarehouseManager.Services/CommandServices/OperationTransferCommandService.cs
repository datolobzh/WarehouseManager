using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.CustomExceptions;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class OperationTransferCommandService : BaseCommandService<OperationTransferModel, OperationTransfer>, IOperationTransferCommand
{
    public OperationTransferCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<OperationTransfer> Repository() => _unitOfWork.OperationTransferRepository;

    public override int Delete(int id) => base.Delete(id);

    public override int Insert(OperationTransferModel model)
    {
        var warehouse = _unitOfWork.WarehouseRepository.Set(w => model.WarehouseToId == w.Id).SingleOrDefault()
            ?? throw new EntityNotFoundException($"User with ID {model.WarehouseToId} not found.");

        if (warehouse.IsDeleted == true) throw new EntityNoLongerActive("This entity has been deleted or is no longer active");

        return base.Insert(model);
    }

    public override void Update(int id, OperationTransferModel model)
    {
        var warehouse = _unitOfWork.WarehouseRepository.Set(w => model.WarehouseToId == w.Id).SingleOrDefault()
            ?? throw new EntityNotFoundException($"User with ID {model.WarehouseToId} not found.");

        if (warehouse.IsDeleted == true) throw new EntityNoLongerActive("This entity has been deleted or is no longer active");

        base.Update(id, model);
    }

}