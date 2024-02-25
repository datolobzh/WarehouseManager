using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public abstract class Operation : IEntity
{
    public int Id { get; set; }
    public ushort Quantity { get; set; }
    public DateTime Date { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; } = null!;

}
