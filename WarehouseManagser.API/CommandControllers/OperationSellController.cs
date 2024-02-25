using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager,Employee")]
[Route("api/commands/operations/operationSell")]
public class OperationSellController : BaseCommandController<OperationSellModel, OperationSell, IOperationSellCommand>
{
    protected override string EntityInsertMessage => "Operation sell has been successful!";

    public OperationSellController(IOperationSellCommand command, ILogger<IOperationSellCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, OperationSellModel model) => base.Edit(id, model);

    [HttpPost("sell")]
    public override IActionResult Insert(OperationSellModel model) => base.Insert(model);
}
