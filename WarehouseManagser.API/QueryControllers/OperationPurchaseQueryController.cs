using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/operations/purchases")]
[Authorize]

public class OperationPurchaseQueryController : BaseQueryController<OperationPurchaseModel, OperationPurchase, IOperationPurchaseQuery>
{
    public OperationPurchaseQueryController(IOperationPurchaseQuery query, ILogger<IOperationPurchaseQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override async Task<ActionResult<IEnumerable<OperationPurchaseModel>>> GetAll() => await base.GetAll();
}
