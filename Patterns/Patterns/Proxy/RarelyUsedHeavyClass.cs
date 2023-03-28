namespace Patterns.Proxy
{
    /// <summary>
    /// Very rarely used heavy class.
    /// </summary>
    public class RarelyUsedHeavyClass : IHeavyClass
    {
        /// <inheritdoc/>
        public int GetValue(int index)
        {
            return this.HeavySearchOperation(index);
        }

        private int HeavySearchOperation(int index)
        {
            return index % 7;
        }
    }
}
