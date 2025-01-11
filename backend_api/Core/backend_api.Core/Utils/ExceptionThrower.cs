using backend_api.Core.Exceptions;

namespace backend_api.Core.Utils;

public class ExceptionThrower
{
    public static void Throws<T>()
        where T : CoreException, new()
    {
        throw new T();
    }
}