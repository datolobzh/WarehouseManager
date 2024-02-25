using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/cities")]
[AllowAnonymous]

public class CityQueryController : BaseQueryController<CityModel, City, ICityQuery>
{
    public CityQueryController(ICityQuery query, ILogger<ICityQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override Task<ActionResult<IEnumerable<CityModel>>> GetAll() => base.GetAll();
}

