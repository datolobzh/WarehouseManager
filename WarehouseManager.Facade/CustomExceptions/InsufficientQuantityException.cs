namespace WarehouseManager.Facade.CustomExceptions;

public class InsufficientQuantityException : InvalidOperationException
{
    public InsufficientQuantityException(string message) : base(message)
    {

    }
}
