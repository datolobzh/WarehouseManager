using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.CustomExceptions;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class OperationSellCommandService : BaseCommandService<OperationSellModel, OperationSell>, IOperationSellCommand
{
    public OperationSellCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<OperationSell> Repository() => _unitOfWork.OperationSellRepository;

    public override int Delete(int id) => base.Delete(id);

    public override int Insert(OperationSellModel model)
    {
        if (model.ProductId <= 0)
            throw new InvalidOperationException("Something has gone wrong!");

        var quantity = _unitOfWork.ProductRepository.Set(a => a.Id == model.ProductId).Select(a => a.Quantity).SingleOrDefault();

        if (quantity < model.Quantity)
            throw new InsufficientQuantityException($"Product with id: {model.Id} cannot be processed, requested quantity: {model.Quantity}, available quanitiy: {quantity}");

        var warehouse = _unitOfWork.WarehouseRepository.Set(w => w.Id == model.WarehouseId).FirstOrDefault()
            ?? throw new EntityNoLongerActive($"Oops, seems like we have an error with warehouse, check values again!");

        if (warehouse.IsDeleted == true)
            throw new EntityNoLongerActive($"Oops, seems like warehouse with an id: {warehouse.Id} is no longer active, check values again!");

        var product = _unitOfWork.ProductRepository.Set(p => p.Id == model.ProductId).FirstOrDefault()
            ?? throw new EntityNotFoundException($"Product with id: {model.ProductId} not found");

        var user = _unitOfWork.UserRepository.Set(u => u.Id == model.UserId).FirstOrDefault();

        if (user?.IsActive == false)
        {
            throw new EntityNoLongerActive($"User with id: {model.UserId} is no longer active");
        }

        product.Quantity -= model.Quantity;

        _unitOfWork.ProductRepository.Update(product);
        //_unitOfWork.SaveChanges();

        int id = base.Insert(model);

        return id;
    }

    public override void Update(int id, OperationSellModel model)
    {
        if (model.ProductId <= 0)
            throw new InvalidOperationException("Something has gone wrong!");

        base.Update(id, model);
    }
}
