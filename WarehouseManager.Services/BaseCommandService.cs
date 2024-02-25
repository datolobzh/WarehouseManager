using AutoMapper;
using WarehouseManager.Facade.CustomExceptions;
using WarehouseManager.Facade.Interfaces.Repositories;
using WarehouseManager.Services.Interfaces.Commands;

namespace WarehouseManager.Services;

public abstract class BaseCommandService<TModel, TEntity> : ICommandModel<TModel, TEntity>
    where TModel : class, IEntityModel
    where TEntity : class, IEntity
{
    protected readonly IMapper _mapper;
    protected readonly IUnitOfWork _unitOfWork;
    protected readonly IRepositoryBase<TEntity> _repository;

    protected abstract IRepositoryBase<TEntity> Repository();

    protected BaseCommandService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _repository = Repository();
    }

    public virtual int Insert(TModel model)
    {
        if (model == null)
            throw new ArgumentNullException("Inserted entity must not be null!");

        TEntity entity = _mapper.Map<TEntity>(model);

        _repository.Insert(entity);
        _unitOfWork.SaveChanges();

        model.Id = entity.Id;
        return model.Id;
    }

    public virtual void Update(int id, TModel model)
    {
        var entity = _repository.Set(u => u.Id == id).SingleOrDefault()
           ?? throw new EntityNotFoundException($"Entity with ID {id} not found.");

        if (entity is IDeletable deletableEntity)
        {
            if (deletableEntity.IsDeleted) throw new EntityDeletedException($"Entity with id #{id} is deleted and cannot be updated");
        }

        model = _mapper.Map<TModel>(entity);

        _repository.Update(entity);
        _unitOfWork!.SaveChanges();
    }

    public virtual int Delete(int id)
    {
        var entity = _repository.Set(p => p.Id == id).SingleOrDefault()
            ?? throw new EntityNotFoundException($"Entity with ID {id} not found.");

        if (entity is IDeletable deletableEntity)
            deletableEntity.IsDeleted = true;

        _repository.Update(entity);
        _unitOfWork?.SaveChanges();

        return entity.Id;
    }

}
