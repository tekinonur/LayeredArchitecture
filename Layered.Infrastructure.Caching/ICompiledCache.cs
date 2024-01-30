namespace Layered.Infrastructure.Caching;

public interface ICompiledCache
{
    object GetOrAdd(string filename, Func<string, object> compilationDelegate, string mimeType);

    void Clear();
}