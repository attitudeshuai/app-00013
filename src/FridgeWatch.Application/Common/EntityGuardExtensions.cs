using FridgeWatch.Domain.Common;

namespace FridgeWatch.Application.Common;

public static class EntityGuardExtensions
{
    public static T ThrowIfNull<T>(this T? entity, string message)
        where T : class
    {
        if (entity == null)
        {
            throw new BusinessException(message);
        }

        return entity;
    }

    public static T ThrowIfNull<T>(this T? entity, string message, int code)
        where T : class
    {
        if (entity == null)
        {
            throw new BusinessException(message, code);
        }

        return entity;
    }
}
