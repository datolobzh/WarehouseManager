using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

[ApiController]
[Authorize(Roles = "Manager,Employee")]
[Route("api/commands/customers")]
public class CustomerCommandController : BaseCommandController<CustomerModel, Customer, ICustomerCommand>
{
    protected override string EntityInsertMessage => "Customer";

    public CustomerCommandController(ICustomerCommand command, ILogger<ICustomerCommand> logger) : base(command, logger) { }

    public override IActionResult Delete(int id) => base.Delete(id);

    public override IActionResult Edit(int id, CustomerModel model) => base.Edit(id, model);

    public override IActionResult Insert(CustomerModel model) => base.Insert(model);
}
