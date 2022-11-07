namespace Patterns.Facade.Kitchen
{
    /// <summary>
    /// Refridgerator.
    /// </summary>
    public class Fridge
    {
        private readonly List<string> products = new ();

        /// <summary>
        /// Initializes a new instance of the <see cref="Fridge"/> class.
        /// </summary>
        /// <param name="capacity">Fridge capacity.</param>
        public Fridge(int capacity)
        {
            this.Capacity = capacity;
        }

        /// <summary>
        /// Gets the capacity of the fridge.
        /// </summary>
        public int Capacity { get; }

        /// <summary>
        /// Gets the products in the fridge.
        /// </summary>
        public IReadOnlyList<string> Products
        {
            get
            {
                return this.products.AsReadOnly();
            }
        }

        /// <summary>
        /// Adds a product to the fridge.
        /// </summary>
        /// <param name="product">New product.</param>
        /// <returns>Returns true if a product was added, false if the fridge is full.</returns>
        public bool AddProduct(string product)
        {
            if (this.products.Count == this.Capacity)
            {
                return false;
            }

            this.products.Add(product);
            return true;
        }

        /// <summary>
        /// Removes a product from fridge.
        /// </summary>
        /// <param name="product">Needed product.</param>
        /// <returns>Returns true if product if in the fridge, false otherwise.</returns>
        public bool TakeProduct(string product)
        {
            if (!this.products.Contains(product))
            {
                return false;
            }

            this.products.Remove(product);
            return true;
        }
    }
}
