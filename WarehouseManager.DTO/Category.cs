using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.DTO;

public sealed class Category : IEntity, IDeletable
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDeleted { get; set; }

    public ICollection<ProductCategory>? ProductCategories { get; set; }
}