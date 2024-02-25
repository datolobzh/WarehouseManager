using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class EmployeeCommandService : BaseCommandService<EmployeeModel, Employee>, IEmployeeCommand
{
    protected override IRepositoryBase<Employee> Repository() => _unitOfWork.EmployeeRepository;

    public EmployeeCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override int Insert(EmployeeModel model) => base.Insert(model);

    public override void Update(int id, EmployeeModel model) => base.Update(id, model);

    public override int Delete(int id)
    {
        var employeeId = base.Delete(id);

        var user = _unitOfWork?.UserRepository.Set(u => u.EmployeeId == employeeId).SingleOrDefault();

        user!.IsDeleted = true;
        user!.IsActive = false;
        _unitOfWork!.UserRepository.Update(user!);

        _unitOfWork!.SaveChanges();
        return id;
    }

}
