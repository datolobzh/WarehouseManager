namespace WarehouseManager.DTO;

public class OperationPurchase : Operation
{
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; } = null!;
}
