using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.CustomExceptions;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.Services;

public class ProductCommandService : BaseCommandService<ProductModel, Product>, IProductCommand
{
    public ProductCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    protected override IRepositoryBase<Product> Repository() => _unitOfWork.ProductRepository;

    public override int Delete(int id) => base.Delete(id);

    public override void Update(int id, ProductModel model) => base.Update(id, model);

    public int Insert(ProductModel model, int categoryId)
    {
        int productId = base.Insert(model);

        var category = _unitOfWork?.CategoryRepository.Set(u => u.Id == categoryId).SingleOrDefault()
            ?? throw new EntityNotFoundException("Category with id {categoryId} is either deleted or not found");

        if (productId > 0)
        {
            _unitOfWork!.ProductCategoryRepository.Insert(new ProductCategory() { CategoryId = categoryId, ProductId = productId });
            _unitOfWork!.SaveChanges();
        }

        return productId;
    }

    public void Delete(int productId, int categoryId)
    {
        var entity = _unitOfWork!.ProductCategoryRepository.Set(pc => pc.ProductId == productId && pc.CategoryId == categoryId).SingleOrDefault()
            ?? throw new EntityNotFoundException("No data found with given ids");

        _unitOfWork!.ProductCategoryRepository.Delete(entity);
        _unitOfWork!.SaveChanges();
    }
}