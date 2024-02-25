namespace WarehouseManager.Facade.CustomExceptions;

public class EntityNotFoundException : InvalidOperationException
{
    public EntityNotFoundException(string message) : base(message)
    {

    }
}
