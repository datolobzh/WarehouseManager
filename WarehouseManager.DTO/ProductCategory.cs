using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public class ProductCategory : IJunction
{
    public int ProductId { get; set; }
    public Product? Product { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
