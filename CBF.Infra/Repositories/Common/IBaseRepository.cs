using CBF.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace CBF.Infra.Repositories.Common;
public interface IBaseRepository<T> where T : EntityBase
{
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool asNoTracking = false);
    Task<T> GetByIdAsync(long id, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<bool> ExistAsync(Expression<Func<T, bool>> filter);
}
