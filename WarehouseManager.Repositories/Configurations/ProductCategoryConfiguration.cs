using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManager.DTO;

namespace WarehouseManager.Repositories.Configurations;

public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasKey(pk => new { pk.ProductId, pk.CategoryId });

        builder.HasOne(p => p.Product)
               .WithMany(pr => pr.ProductCategories)
               .HasForeignKey(p => p.ProductId);

        builder.HasOne(c => c.Category)
               .WithMany(pr => pr.ProductCategories)
               .HasForeignKey(c => c.CategoryId);

    }
}
