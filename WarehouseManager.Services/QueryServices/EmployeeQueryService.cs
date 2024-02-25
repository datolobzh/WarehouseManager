using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class EmployeeQueryService : BaseQueryService<EmployeeModel, Employee>, IEmployeeQuery
{
    protected override IRepositoryBase<Employee> Repository() => _unitOfWork.EmployeeRepository;

    public EmployeeQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override EmployeeModel GetById(int id) => base.GetById(id);

    public override IQueryable<EmployeeModel> Set(Expression<Func<Employee, bool>> predicate) => base.Set(predicate);

    public override  IEnumerable<EmployeeModel> Set() => base.Set();

}
