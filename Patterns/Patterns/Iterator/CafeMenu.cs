namespace Patterns.Iterator
{
    /// <summary>
    /// Cafe menu.
    /// </summary>
    public class CafeMenu
    {
        private readonly List<MenuItem> menuItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="CafeMenu"/> class.
        /// </summary>
        /// <param name="menuItems">Menu items for the cafe.</param>
        public CafeMenu(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        /// <summary>
        /// Return iterator for the menu.
        /// </summary>
        /// <returns>Iterator.</returns>
        public IMenuItemIterator GetIterator()
        {
            return new CafeMenuIterator(this.menuItems);
        }
    }
}