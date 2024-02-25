using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/countries")]
[AllowAnonymous]

public class CountryQueryController : BaseQueryController<CountryModel, Country, ICountryQuery>
{
    public CountryQueryController(ICountryQuery query, ILogger<ICountryQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override Task<ActionResult<IEnumerable<CountryModel>>> GetAll() => base.GetAll();
}

