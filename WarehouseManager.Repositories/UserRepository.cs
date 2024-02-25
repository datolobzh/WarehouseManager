using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

internal class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(WarehouseDbContext context) : base(context) { }

    public User? GetByUserName(string username) => _dbSet.SingleOrDefault(u => u.Username == username);
}