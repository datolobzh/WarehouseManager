namespace WarehouseManager.Facade.Interfaces.Repositories;

public interface IJunction { }

public interface IEntityModel : IEntityModel<int> { }

public interface IEntity : IEntity<int> { }

public interface IEntity<out T> : IJunction
{
    T Id { get; }
}

public interface IDeletable
{
    bool IsDeleted { get; set; }
}

public interface IEntityModel<T> : IJunction
{
    T Id { get; set; }
}

