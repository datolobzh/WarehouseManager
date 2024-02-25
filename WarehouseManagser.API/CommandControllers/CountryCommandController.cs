using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Route("api/commands/countries")]
[Authorize(Roles = "Manager,Employee")]

public class CountryCommandController : BaseCommandController<CountryModel, Country, ICountryCommand>
{
    public CountryCommandController(ICountryCommand command, ILogger<ICountryCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, CountryModel model) => base.Edit(id, model);

    public override IActionResult Insert(CountryModel model) => base.Insert(model);
}
