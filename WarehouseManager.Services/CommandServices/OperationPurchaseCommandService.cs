using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.CustomExceptions;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class OperationPurchaseCommandService : BaseCommandService<OperationPurchaseModel, OperationPurchase>, IOperationPurchaseCommand
{
    public OperationPurchaseCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<OperationPurchase> Repository() => _unitOfWork.OperationPurchaseRepository;

    public override void Update(int id, OperationPurchaseModel model)
    {
        var supplier = _unitOfWork.SupplierRepository.Set(sup => sup.Id == model.SupplierId).SingleOrDefault()
            ?? throw new EntityNotFoundException($"Supplier with ID {model.SupplierId} not found.");

        if (supplier.IsDeleted == true) throw new EntityNoLongerActive("This entity has been deleted or is no longer active");

        base.Update(id, model);
    }

    public override int Delete(int id) => base.Delete(id);

    public override int Insert(OperationPurchaseModel model) => base.Insert(model);

}
