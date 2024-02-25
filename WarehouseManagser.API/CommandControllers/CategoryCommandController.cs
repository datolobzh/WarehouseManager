using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Controllers;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.CommandControllers;

[ApiController]
[Route("api/commands/categories")]
[Authorize(Roles = "Manager,Employee")]

public class CategoryCommandController : BaseCommandController<CategoryModel, Category, ICategoryCommand>
{
    public CategoryCommandController(ICategoryCommand command, ILogger<ICategoryCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, CategoryModel model) => base.Edit(id, model);

    public override IActionResult Insert(CategoryModel model) => base.Insert(model);

}
