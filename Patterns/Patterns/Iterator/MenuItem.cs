namespace Patterns.Iterator
{
    /// <summary>
    /// Menu item.
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem"/> class.
        /// </summary>
        /// <param name="name">Name of the item.</param>
        /// <param name="isGlutenFree">Indicates whether the item is gluten free.</param>
        public MenuItem(string name, bool isGlutenFree)
        {
            this.Name = name;
            this.IsGlutenFree = isGlutenFree;
        }

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item is gluten free.
        /// </summary>
        public bool IsGlutenFree { get; set; }
    }
}