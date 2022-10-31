namespace Patterns.SOLID.SingleResponsibility
{
    /// <summary>
    /// Store.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Selling a product.
        /// </summary>
        /// <param name="productName">Product name.</param>
        public void SellProducts(string productName)
        {
            Console.WriteLine($"Sell a product: {productName}.");
        }
    }
}
