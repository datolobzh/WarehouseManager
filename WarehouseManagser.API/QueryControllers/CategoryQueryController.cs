using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/categories")]
[AllowAnonymous]

public class CategoryQueryController : BaseQueryController<CategoryModel, Category, ICategoryQuery>
{
    public CategoryQueryController(ICategoryQuery query, ILogger<ICategoryQuery> logger) : base(query,logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override async Task<ActionResult<IEnumerable<CategoryModel>>> GetAll() => await base.GetAll();

}

