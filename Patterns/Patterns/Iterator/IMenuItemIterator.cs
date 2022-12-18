namespace Patterns.Iterator
{
    /// <summary>
    /// Iterator interface.
    /// </summary>
    public interface IMenuItemIterator
    {
        /// <summary>
        /// Next element.
        /// </summary>
        /// <returns>Returns next element.</returns>
        MenuItem Next();

        /// <summary>
        /// Specifies whether there is a next element.
        /// </summary>
        /// <returns>True if there is a next element.</returns>
        bool HasNext();
    }
}