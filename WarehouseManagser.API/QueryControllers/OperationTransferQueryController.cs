using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/operations/transfers")]
[Authorize(Roles = "Manager")]

public class OperationTransferQueryController : BaseQueryController<OperationTransferModel, OperationTransfer, IOperationTransferQuery>
{
    public OperationTransferQueryController(IOperationTransferQuery query, ILogger<IOperationTransferQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override async Task<ActionResult<IEnumerable<OperationTransferModel>>> GetAll() => await base.GetAll();
}