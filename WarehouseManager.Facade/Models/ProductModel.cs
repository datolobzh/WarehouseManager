using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.API.Models;

public class ProductModel : IEntityModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal SellPrice { get; set; }
    public ushort Quantity { get; set; }
}

