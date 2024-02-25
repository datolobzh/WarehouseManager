using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/operations/disposals")]
[Authorize(Roles = "Manager")]

public class OperationDisposalQueryController : BaseQueryController<OperationDisposalModel, OperationDisposal, IOperationDisposalQuery>
{
    public OperationDisposalQueryController(IOperationDisposalQuery query, ILogger<IOperationDisposalQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override async Task<ActionResult<IEnumerable<OperationDisposalModel>>> GetAll() => await base.GetAll();
}
