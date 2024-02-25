using AutoMapper;
using System.Linq.Expressions;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Queries;

namespace WarehouseManager.Services;

public abstract class BaseQueryService<TModel, TEntity> : IQueryModel<TModel, TEntity>
    where TModel : class, IEntityModel
    where TEntity : class, IEntity
{
    protected readonly IMapper _mapper;
    protected readonly IUnitOfWork _unitOfWork;
    protected readonly IRepositoryBase<TEntity> _repository;

    protected abstract IRepositoryBase<TEntity> Repository();

    protected BaseQueryService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _repository = Repository();
    }

    public virtual TModel GetById(int id)
    {
        var entity = _repository.Set(a => a.Id == id).SingleOrDefault()
            ?? throw new ArgumentNullException(nameof(id), "Entity not found with the specified ID");

        var model = _mapper.Map<TModel>(entity);

        model.Id = entity.Id;

        return model;
    }

    public virtual IQueryable<TModel> Set(Expression<Func<TEntity, bool>> predicate)
    {
        var entities = _repository.Set(predicate);

        var modelEntities = entities
            .Select(entity => _mapper.Map<TModel>(entity));

        return modelEntities;
    }

    public virtual IEnumerable<TModel> Set()
    {
        var entities = _repository.Set();

        var models = entities
            .Select(entity => _mapper.Map<TModel>(entity));

        return models.ToList();
    }

}
