namespace FridgeWatch.Domain.Common;

public static class GuardExtensions
{
    public static async Task<T> ThrowIfNullAsync<T>(this Task<T?> task, string errorMessage, int errorCode = 400)
        where T : class
    {
        var value = await task;
        if (value == null)
        {
            throw new BusinessException(errorMessage, errorCode);
        }
        return value;
    }
}
