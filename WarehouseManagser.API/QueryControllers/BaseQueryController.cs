using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.API.QueryControllers;

public abstract class BaseQueryController<TModel, TEntity, TQueryModelController> : Controller
    where TModel : IEntityModel
    where TEntity : class, IEntity
    where TQueryModelController : IQueryModel<TModel, TEntity>
{
    protected readonly TQueryModelController _query;
    protected ILogger<TQueryModelController> _logger;

    public BaseQueryController(TQueryModelController query, ILogger<TQueryModelController> logger)
    {
        _query = query;
        _logger = logger;
    }

    [HttpGet("getAll")]
    public async virtual Task<ActionResult<IEnumerable<TModel>>> GetAll()
    {
        try
        {
          var result = await Task.Run(_query.Set);

          return Ok(result);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An error occurred while retrieving data.");
            return BadRequest($"could not retrieve data: {e.Message}");
        }
    }

    [HttpGet("getById/{id}")]
    public async virtual Task<IActionResult> GetById([FromRoute] int id)
    {
        try
        {
            var result = await Task.Run(() => _query.GetById(id));

            return Ok(result);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An error occurred while retrieving data.");
            return BadRequest($"could not retrieve data: {e.Message}");
        }
    }

    protected async Task<ActionResult<IQueryable<TModel>>> FilterQuery(Expression<Func<TEntity, bool>> expression)
    {
        try
        {
            var result = await Task.Run(() => _query.Set(expression));
            return Ok(result);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An error occurred while retrieving data.");
            return BadRequest($"could not retrieve data: {e.Message}");
        }
    }

}