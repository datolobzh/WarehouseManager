using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager,Employee")]
[Route("api/commands/operations/operationPurchase")]
public class OperationPurchaseController : BaseCommandController<OperationPurchaseModel, OperationPurchase, IOperationPurchaseCommand>
{
    protected override string EntityInsertMessage => "Operation purchase has been successful";

    public OperationPurchaseController(IOperationPurchaseCommand command, ILogger<IOperationPurchaseCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, OperationPurchaseModel model) => base.Edit(id, model);

    [HttpPost("purchase")]
    public override IActionResult Insert(OperationPurchaseModel model) => base.Insert(model);
}
