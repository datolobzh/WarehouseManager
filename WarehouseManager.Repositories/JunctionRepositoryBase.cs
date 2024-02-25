using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WarehouseManager.Facade.Interfaces.Repositories;

namespace WarehouseManager.Repositories;

public abstract class JunctionRepositoryBase<TJunction> : IRepositoryJunction<TJunction>
    where TJunction : class, IJunction
{
    protected readonly WarehouseDbContext _context;
    protected readonly DbSet<TJunction> _dbSet;

    public JunctionRepositoryBase(WarehouseDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = context.Set<TJunction>();
    }

    public void Delete(TJunction entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        _dbSet.Remove(entity);
    }

    public void Insert(TJunction entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        _dbSet.Add(entity);
    }

    public IQueryable<TJunction> Set(Expression<Func<TJunction, bool>> predicate) => _dbSet.Where(predicate).AsNoTracking();

    public void Update(TJunction entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        _dbSet.Update(entity);
    }
}