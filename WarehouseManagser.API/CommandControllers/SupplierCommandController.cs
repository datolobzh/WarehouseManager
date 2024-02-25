using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager")]
[Route("api/commands/suppliers")]
public class SupplierCommandController : BaseCommandController<SupplierModel, Supplier, ISupplierCommand>
{
    public SupplierCommandController(ISupplierCommand command, ILogger<ISupplierCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, SupplierModel model) => base.Edit(id, model);

    public override IActionResult Insert(SupplierModel model) => base.Insert(model);
}
