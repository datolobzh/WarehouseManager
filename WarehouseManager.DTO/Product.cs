using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public sealed class Product : IEntity, IDeletable
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal SellPrice { get; set; }
    public ushort Quantity { get; set; }
    public bool IsDeleted { get; set; }

    public ICollection<ProductCategory>? ProductCategories { get; set; }
    public ICollection<Operation>? Operations { get; }

}
