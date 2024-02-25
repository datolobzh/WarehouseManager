using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

[ApiController]
[Route("api/queries/customers")]
[Authorize(Roles = "Manager")]

public class CustomerQueryController : BaseQueryController<CustomerModel, Customer, ICustomerQuery>
{
    public CustomerQueryController(ICustomerQuery query, ILogger<ICustomerQuery> logger) : base(query, logger) { }

    public override Task<IActionResult> GetById([FromRoute] int id) => base.GetById(id);

    public override async Task<ActionResult<IEnumerable<CustomerModel>>> GetAll() => await base.GetAll();
}

