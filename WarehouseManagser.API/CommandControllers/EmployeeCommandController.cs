using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WarehouseManager.API.Models;
using WarehouseManager.DTO;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers
{
    [ApiController]
    [Authorize(Roles = "Admin")]
    [Route("api/commands/employees")]
    public class EmployeeCommandController : BaseCommandController<EmployeeModel, Employee, IEmployeeCommand>
    {
        protected override string EntityInsertMessage => "Employee registered successfully!";

        public EmployeeCommandController(IEmployeeCommand command, ILogger<IEmployeeCommand> logger) : base(command, logger) { }

        public override IActionResult Delete(int id) => base.Delete(id);

        public override IActionResult Edit(int id, EmployeeModel model) => base.Edit(id, model);

        public override IActionResult Insert(EmployeeModel model) => base.Insert(model);

    }
}
