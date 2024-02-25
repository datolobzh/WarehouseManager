using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/operations/sells")]
[Authorize(Roles = "Manager")]

public class OperationSellQueryController : BaseQueryController<OperationSellModel, OperationSell, IOperationSellQuery>
{
    public OperationSellQueryController(IOperationSellQuery query, ILogger<IOperationSellQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override async Task<ActionResult<IEnumerable<OperationSellModel>>> GetAll() => await base.GetAll(); 
}
