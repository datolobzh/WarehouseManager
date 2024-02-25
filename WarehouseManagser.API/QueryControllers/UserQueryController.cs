using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/users")]
[Authorize(Roles = "Manager")]

public class UserQueryController : BaseQueryController<UserModel, User, IUserQuery>
{
    public UserQueryController(IUserQuery query, ILogger<IUserQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override async Task<ActionResult<IEnumerable<UserModel>>> GetAll() =>await base.GetAll();
}

