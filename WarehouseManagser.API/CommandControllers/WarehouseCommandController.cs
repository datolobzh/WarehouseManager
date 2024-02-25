using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager")]
[Route("api/commands/warehouses")]
public class WarehouseCommandController : BaseCommandController<WarehouseModel, Warehouse, IWarehouseCommand>
{
    protected override string EntityInsertMessage => "Warehouse has been successfully added!";

    public WarehouseCommandController(IWarehouseCommand command, ILogger<IWarehouseCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, WarehouseModel model) => base.Edit(id, model);

    public override IActionResult Insert(WarehouseModel model) => base.Insert(model);
}
