namespace Patterns.FactoryMethod
{
    /// <summary>
    /// Stock operation.
    /// </summary>
    public class StockOperation : Oper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockOperation"/> class.
        /// </summary>
        /// <param name="account">Account for the operation.</param>
        /// <param name="amount">Amount of the operation.</param>
        public StockOperation(string account, decimal amount)
            : base(account + "-STOCK", amount)
        {
        }
    }
}
