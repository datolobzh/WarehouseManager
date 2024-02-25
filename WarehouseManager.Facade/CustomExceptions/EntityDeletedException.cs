namespace WarehouseManager.Facade.CustomExceptions;

public class EntityDeletedException : InvalidOperationException
{
    public EntityDeletedException(string message) : base(message)
    {

    }
}