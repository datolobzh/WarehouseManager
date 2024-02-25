using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;


namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager,Employee")]
[Route("api/commands/users")]
public class UserCommandController : BaseCommandController<UserModel, User, IUserCommand>
{
    protected override string EntityInsertMessage => "User has successfully linked to employee!";

    public UserCommandController(IUserCommand command, ILogger<IUserCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, UserModel model) => base.Edit(id, model);

    public override IActionResult Insert(UserModel model) => base.Insert(model);

    [HttpPost("deactivate/{id}")]
    public IActionResult Deactivate(int id)
    {
        try
        {
            _command.Deactivate(id);
        }
        catch (Exception)
        {
            return BadRequest("Uh,oh operation failed");
        }

        return Ok("User deactivated!");
    }

    [HttpPost("activate/{id}")]
    public IActionResult Activate(int id)
    {
        try
        {
            _command.Activate(id);
        }
        catch (Exception)
        {
            return BadRequest("Uh,oh operation failed");
        }

        return Ok("User activated!");
    }

}
