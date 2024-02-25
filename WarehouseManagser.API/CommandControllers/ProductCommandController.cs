using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager,Employee")]
[Route("api/commands/products")]
public class ProductCommandController : BaseCommandController<ProductModel, Product, IProductCommand>
{
    public ProductCommandController(IProductCommand command, ILogger<IProductCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, ProductModel model) => base.Edit(id, model);

    public override IActionResult Insert(ProductModel model) => base.Insert(model);

    [HttpPost("category/insert/{id}")]
    public IActionResult Insert(ProductModel model, int id)
    {
        try
        {
            _command.Insert(model, id);
        }
        catch (Exception ex)
        {
            return BadRequest($"Uh,oh operation failed, reason: {ex.Message}");
        }

        return Ok("Product inserted successfully!");
    }

    [HttpPost("category/delete/{productId}/{categoryId}")]
    public IActionResult Delete(int productId, int categoryId)
    {
        try
        {
            _command.Delete(productId, categoryId);
        }
        catch (Exception ex)
        {
            return BadRequest($"Uh,oh operation failed, reason: {ex.Message}");
        }

        return Ok("Product category deleted successfully!");
    }
}
