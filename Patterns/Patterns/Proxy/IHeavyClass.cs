namespace Patterns.Proxy
{
    /// <summary>
    /// Interface for a heavy class.
    /// </summary>
    public interface IHeavyClass
    {
        /// <summary>
        /// Searches for a value.
        /// </summary>
        /// <param name="index">Some index for search.</param>
        /// <returns>Searched value.</returns>
        int GetValue(int index);
    }
}
