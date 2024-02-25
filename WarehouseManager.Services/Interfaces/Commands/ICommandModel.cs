using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Services.Interfaces.Commands;

public interface ICommandModel<TEntityModel, TEntity>
where TEntityModel : IEntityModel
where TEntity : IEntity
{
    int Insert(TEntityModel model);
    void Update(int id, TEntityModel model);
    int Delete(int id);
}

public interface ICommandJunctionModel<TEntityModel, TEntity> : ICommandModel<TEntityModel, TEntity>
    where TEntityModel : IEntityModel
    where TEntity : IEntity
{
    void Update(int id, TEntityModel model, int outerId);
}




