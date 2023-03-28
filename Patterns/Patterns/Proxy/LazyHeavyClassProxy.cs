namespace Patterns.Proxy;

/// <summary>
/// Lazy loader for a heavy and rarely used class.
/// </summary>
internal class LazyHeavyClassProxy : IHeavyClass
{
    private readonly Dictionary<int, int> cache = new ();
    private IHeavyClass? heavyClass;

    /// <inheritdoc/>
    public int GetValue(int index)
    {
        if (this.cache.ContainsKey(index))
        {
            return this.cache[index];
        }

        this.heavyClass ??= new RarelyUsedHeavyClass();
        int result = this.heavyClass.GetValue(index);
        this.cache[index] = result;

        return result;
    }
}