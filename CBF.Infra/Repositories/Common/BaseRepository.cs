using CBF.Domain.Entities.Common;
using CBF.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace CBF.Infra.Repositories.Common;

public class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
{
    protected readonly CBFContext _context;
    protected readonly DbSet<T> _dbSet;

    public BaseRepository(CBFContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public virtual async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<T> UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task DeleteAsync(T entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task<T> GetByIdAsync(long id, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
    {
        var query = _dbSet.AsQueryable();

        if (include != null)
            query = include(query);

        return await query.FirstOrDefaultAsync(x => x.Id == id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool asNoTracking = false)
    {
        var query = _dbSet.AsQueryable();

        if (filter != null)
            query = query.Where(filter);

        if (include != null)
            query = include(query);

        if (asNoTracking)
            query = query.AsNoTracking();

        return await query.ToListAsync();
    }
}
