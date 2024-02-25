using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/employees")]
[Authorize(Roles = "Manager")]

public class EmployeeQueryController : BaseQueryController<EmployeeModel, Employee, IEmployeeQuery>
{
    public EmployeeQueryController(IEmployeeQuery query, ILogger<IEmployeeQuery> logger) : base(query, logger) { }

    public override async Task<ActionResult<IEnumerable<EmployeeModel>>> GetAll() => await base.GetAll();

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    [HttpGet("getByIdentityNumber/{IdentityNumber}")]
    public async Task<EmployeeModel> FilterByIdentity([FromRoute] string IdentityNumber)
    {
        var result = await Task.Run(() => _query.Set(e => e.IdentityNumber == IdentityNumber));
        return (EmployeeModel) result;
    }
       
    [HttpGet("getByName")]
    public async Task<ActionResult<IQueryable<EmployeeModel>>> FilterByName([FromQuery] string firstName,string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            return BadRequest("At least one of 'firstName' or 'lastName' parameters is required.");

        var result = await FilterQuery(e => e.FirstName == firstName!.Trim() || e.LastName == lastName!.Trim());

        return result;
    }
}