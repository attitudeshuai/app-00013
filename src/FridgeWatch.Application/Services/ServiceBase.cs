using FridgeWatch.Domain.Common;

namespace FridgeWatch.Application.Services;

public abstract class ServiceBase
{
    protected static async Task<TEntity> GetOrThrowAsync<TEntity>(
        Func<Task<TEntity?>> fetchFunc,
        string errorMessage)
        where TEntity : class
    {
        var entity = await fetchFunc();
        if (entity == null)
        {
            throw new BusinessException(errorMessage);
        }
        return entity;
    }
}
