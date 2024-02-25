using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/suppliers")]
[Authorize(Roles = "Manager")]

public class SupplierQueryController : BaseQueryController<SupplierModel, Supplier, ISupplierQuery>
{
    public SupplierQueryController(ISupplierQuery query, ILogger<ISupplierQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override async Task<ActionResult<IEnumerable<SupplierModel>>> GetAll() => await base.GetAll();
}

