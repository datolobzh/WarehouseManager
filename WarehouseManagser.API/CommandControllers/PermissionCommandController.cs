using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager")]
[Route("api/commands/permissions")]
public class PermissionCommandController : BaseCommandController<PermissionModel, Permission, IPermissionCommand>
{

    public PermissionCommandController(IPermissionCommand command, ILogger<IPermissionCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, PermissionModel model) => base.Edit(id, model);

    public override IActionResult Insert(PermissionModel model) => base.Insert(model);
}
