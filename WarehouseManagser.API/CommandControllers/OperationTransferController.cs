using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager")]
[Route("api/commands/operations/operationTransfer")]
public class OperationTransferController : BaseCommandController<OperationTransferModel, OperationTransfer, IOperationTransferCommand>
{
    protected override string EntityInsertMessage => "Operation transfer has been successful!";

    public OperationTransferController(IOperationTransferCommand command, ILogger<IOperationTransferCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, OperationTransferModel model) => base.Edit(id, model);

    [HttpPost("transfer")]
    public override IActionResult Insert(OperationTransferModel model) => base.Insert(model);
}
