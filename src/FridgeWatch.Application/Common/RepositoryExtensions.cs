using FridgeWatch.Domain.Common;
using FridgeWatch.Domain.Interfaces;

namespace FridgeWatch.Application.Common;

public static class RepositoryExtensions
{
    public static async Task<TEntity> GetByIdOrThrowAsync<TEntity, TKey>(
        this IRepository<TEntity, TKey> repository,
        TKey id,
        string message)
        where TEntity : BaseEntity<TKey>
    {
        var entity = await repository.GetByIdAsync(id);
        if (entity == null)
        {
            throw new BusinessException(message);
        }

        return entity;
    }

    public static async Task<TEntity> GetByIdOrThrowAsync<TEntity, TKey>(
        this IRepository<TEntity, TKey> repository,
        TKey id,
        string message,
        int code)
        where TEntity : BaseEntity<TKey>
    {
        var entity = await repository.GetByIdAsync(id);
        if (entity == null)
        {
            throw new BusinessException(message, code);
        }

        return entity;
    }
}
