using Microsoft.AspNetCore.Mvc;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.API.Controllers;

public abstract class BaseCommandController<TModel, TEntity, TCommandController> : Controller
    where TModel : IEntityModel
    where TEntity : IEntity
    where TCommandController : ICommandModel<TModel, TEntity>
{
    protected readonly TCommandController _command;
    protected ILogger<TCommandController> _logger;

    protected virtual string EntityInsertMessage => "Entity inserted successfully!";
    protected virtual string EntityDeletedMessage => "Entity deleted successfully!";
    protected virtual string EntityUpdatedMessage => "Entity updated successfully!";
    protected virtual string EntityBadMessage => "Uh,oh operation failed";

    public BaseCommandController(TCommandController command, ILogger<TCommandController> logger)
    {
        _command = command;
        _logger = logger;
    }

    [HttpPost("delete/{id}")]
    public virtual IActionResult Delete([FromRoute] int id)
    {
        try
        {
            _command.Delete(id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"An error occurred while retrieving data: {ex.Message}");
            return BadRequest($"{EntityBadMessage}, reason: {ex.Message}");
        }

        return Ok(EntityDeletedMessage);
    }

    [HttpPost("edit/{id}")]
    public virtual IActionResult Edit([FromRoute] int id, [FromBody] TModel model)
    {
        try
        {
            _command.Update(id, model);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"An error occurred while retrieving data: {ex.Message}");
            return BadRequest($"{EntityBadMessage}, reason: {ex.Message}");
        }

        return Ok(EntityUpdatedMessage);
    }

    [HttpPost("insert")]
    public virtual IActionResult Insert([FromBody] TModel model)
    {
        try
        {
            _command.Insert(model);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"An error occurred while retrieving data: {ex.Message}");
            return BadRequest($"{EntityBadMessage}, reason: {ex.Message}");
        }

        return Ok(EntityInsertMessage);
    }
}
