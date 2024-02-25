namespace WarehouseManager.DTO;

public class OperationSell : Operation
{
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}
