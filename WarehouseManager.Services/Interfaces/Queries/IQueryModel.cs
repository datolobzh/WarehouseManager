using System.Linq.Expressions;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Services.Interfaces.Queries;

public interface IQueryModel<TQueryModel, TEntity>
    where TQueryModel : IEntityModel
    where TEntity : class, IEntity
{
   TQueryModel GetById(int id);
   IQueryable<TQueryModel> Set(Expression<Func<TEntity, bool>> predicate);
   IEnumerable<TQueryModel> Set();
}
