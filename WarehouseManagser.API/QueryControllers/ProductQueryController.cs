using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/products")]
[AllowAnonymous]

public class ProductQueryController : BaseQueryController<ProductModel, Product, IProductQuery>
{
    public ProductQueryController(IProductQuery query, ILogger<IProductQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override async Task<ActionResult<IEnumerable<ProductModel>>> GetAll() => await base.GetAll();
}

