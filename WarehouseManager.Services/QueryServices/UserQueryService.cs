using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services.QueryServices;

public class UserQueryService : BaseQueryService<UserModel, User>, IUserQuery
{
    protected override IRepositoryBase<User> Repository() => _unitOfWork.UserRepository;

    public UserQueryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override UserModel GetById(int id) => base.GetById(id);

    public override IQueryable<UserModel> Set(Expression<Func<User, bool>> predicate) => base.Set(predicate);

    public override IEnumerable<UserModel> Set() => base.Set();

}
 