using AutoMapper;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services.CommandServices;

public class CategoryCommandService : BaseCommandService<CategoryModel, Category>, ICategoryCommand
{
    protected override IRepositoryBase<Category> Repository() => _unitOfWork.CategoryRepository;

    public CategoryCommandService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

    public override int Insert(CategoryModel model) => base.Insert(model);

    public override void Update(int id, CategoryModel model) => base.Update(id, model);

    public override int Delete(int id) => base.Delete(id);

}
