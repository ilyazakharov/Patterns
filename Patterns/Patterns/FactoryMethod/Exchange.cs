namespace Patterns.FactoryMethod
{
    /// <summary>
    /// Exchange.
    /// </summary>
    public class Exchange : OperationCreator
    {
        /// <inheritdoc/>
        public override Oper CreateOperation(string account, decimal amount)
        {
            return new StockOperation(account, amount);
        }
    }
}