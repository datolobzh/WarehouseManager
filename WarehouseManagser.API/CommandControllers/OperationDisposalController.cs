using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager")]
[Route("api/commands/operations/operationDispose")]
public class OperationDisposalController : BaseCommandController<OperationDisposalModel, OperationDisposal, IOperationDisposalCommand>
{
    protected override string EntityInsertMessage => "Operation dispose has been successful!";

    public OperationDisposalController(IOperationDisposalCommand command, ILogger<IOperationDisposalCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, OperationDisposalModel model) => base.Edit(id, model);

    [HttpPost("dispose")]
    public override IActionResult Insert(OperationDisposalModel model) => base.Insert(model);
}
