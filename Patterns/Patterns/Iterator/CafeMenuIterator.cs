namespace Patterns.Iterator
{
    /// <summary>
    /// Cafe menu iterator.
    /// </summary>
    public class CafeMenuIterator : IMenuItemIterator
    {
        private readonly List<MenuItem> menuItems;
        private int current = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="CafeMenuIterator"/> class.
        /// </summary>
        /// <param name="menuItems">Menu items.</param>
        public CafeMenuIterator(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        /// <inheritdoc/>
        public bool HasNext()
        {
            if (this.menuItems == null)
            {
                return false;
            }

            return this.menuItems.Count > this.current;
        }

        /// <inheritdoc/>
        public MenuItem Next()
        {
            MenuItem cur = this.menuItems[this.current];
            this.current++;
            return cur;
        }
    }
}