namespace WarehouseManager.DTO;

public class DispatchingOperation : Operation
{
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; } = null!;
}
