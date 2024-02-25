using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Route("api/commands/cities")]
[Authorize(Roles = "Manager,Employee")]

public class CityCommandController : BaseCommandController<CityModel, City, ICityCommand>
{
    public CityCommandController(ICityCommand command, ILogger<ICityCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, CityModel model) => base.Edit(id, model);

    public override IActionResult Insert(CityModel model) => base.Insert(model);
}
