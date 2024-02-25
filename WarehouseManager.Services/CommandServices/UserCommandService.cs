using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.CustomExceptions;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class UserCommandService : BaseCommandService<UserModel, User>, IUserCommand
{
    protected override IRepositoryBase<User> Repository() => _unitOfWork.UserRepository;

    public UserCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override void Update(int id, UserModel model) => base.Update(id, model);

    public void Activate(int id)
    {
        var user = _repository.Set(p => p.Id == id).SingleOrDefault()
            ?? throw new EntityNotFoundException($"User with ID {id} not found.");

        user.IsActive = true;

        _repository.Update(user);
        _unitOfWork!.SaveChanges();
    }

    public void Deactivate(int id)
    {
        var user = _repository.Set(p => p.Id == id).SingleOrDefault()
            ?? throw new EntityNotFoundException($"User with ID {id} not found.");

        user.IsActive = false;

        _repository.Update(user);
        _unitOfWork!.SaveChanges();
    }

    public override int Delete(int id)
    {
        var user = _repository.Set(p => p.Id == id).SingleOrDefault()
            ?? throw new EntityNotFoundException($"User with ID {id} not found.");

        user.IsDeleted = true;
        user.IsActive = false;

        _repository.Update(user);
        _unitOfWork!.SaveChanges();

        return user.Id;
    }

    public override int Insert(UserModel model)
    {
        base.Insert(model);

        var employee = _repository.Set(e => e.Id == model.EmployeeId).SingleOrDefault()
            ?? throw new EntityNotFoundException($"Relevant employee not found.");

        var user = _mapper.Map<User>(model);

        _repository.Insert(user);
        _unitOfWork.SaveChanges();

        return user.Id;
    }

}