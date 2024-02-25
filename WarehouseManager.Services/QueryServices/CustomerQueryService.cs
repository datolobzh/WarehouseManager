using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class CustomerQueryService : BaseQueryService<CustomerModel, Customer>, ICustomerQuery
{
    protected override IRepositoryBase<Customer> Repository() => _unitOfWork.CustomerRepository;

    public CustomerQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override CustomerModel GetById(int id) => base.GetById(id);

    public override IEnumerable<CustomerModel> Set() => base.Set();

    public override IQueryable<CustomerModel> Set(Expression<Func<Customer, bool>> predicate) => base.Set(predicate);

}