using CBF.Domain.Entities.Common;
using CBF.Domain.Response;
using Microsoft.EntityFrameworkCore;

namespace CBF.Infra.Utils;
public static class IQueryableExtension
{
    public static async Task<PagedResponse<T>> GetPagedAsync<T>(this IQueryable<T> query, int page = 1, double pageResults = 25f) where T : EntityBase
    {
        query = query.OrderByDescending(x => x.Created);

        var totalItems = await query.CountAsync();
        var pageCount = Math.Ceiling(totalItems / pageResults);

        var data = await query
                           .Skip((page - 1) * (int)pageResults)
                           .Take((int)pageResults)
                           .ToListAsync();

        return new PagedResponse<T>
        {
            Result = data,
            Pages = (int)pageCount,
            CurrentPage = page,
            TotalItems = totalItems
        };
    }
}
