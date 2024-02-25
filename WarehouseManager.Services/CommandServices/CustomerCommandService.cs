using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class CustomerCommandService : BaseCommandService<CustomerModel, Customer>, ICustomerCommand
{
    protected override IRepositoryBase<Customer> Repository() => _unitOfWork.CustomerRepository;

    public CustomerCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override int Insert(CustomerModel model) => base.Insert(model);

    public override void Update(int id, CustomerModel model) => base.Update(id, model);

    public override int Delete(int id) => base.Delete(id);
}