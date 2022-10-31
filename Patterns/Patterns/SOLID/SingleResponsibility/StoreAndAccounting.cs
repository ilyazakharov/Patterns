namespace Patterns.SOLID.SingleResponsibility
{
    /// <summary>
    /// A store.
    /// </summary>
    public class StoreAndAccounting
    {
        /// <summary>
        /// Selling a product.
        /// </summary>
        /// <param name="productName">Product name.</param>
        public void SellProducts(string productName)
        {
            Console.WriteLine($"Sell a product: {productName}.");
        }

        /// <summary>
        /// Calculating an employee's salary.
        /// </summary>
        /// <param name="employeeName">Employee name.</param>
        public void CalculateSalary(string employeeName)
        {
            Console.WriteLine($"Calculated {employeeName}'s salary.");
        }
    }
}
