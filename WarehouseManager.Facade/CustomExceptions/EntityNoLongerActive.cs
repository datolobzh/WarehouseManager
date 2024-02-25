namespace WarehouseManager.Facade.CustomExceptions;

public class EntityNoLongerActive : InvalidOperationException
{
    public EntityNoLongerActive(string message) : base(message)
    {

    }
}
