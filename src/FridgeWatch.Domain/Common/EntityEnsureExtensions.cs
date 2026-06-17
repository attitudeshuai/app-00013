namespace FridgeWatch.Domain.Common;

public static class EntityEnsureExtensions
{
    public static T EnsureExists<T>(this T? entity, string errorMessage) where T : class
    {
        if (entity == null)
            throw new BusinessException(errorMessage);

        return entity;
    }
}
