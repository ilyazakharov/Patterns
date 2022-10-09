namespace Patterns.FactoryMethod
{
    /// <summary>
    /// Bank.
    /// </summary>
    public class OperationalBank : OperationCreator
    {
        /// <inheritdoc/>
        public override Oper CreateOperation(string account, decimal amount)
        {
            return new MoneyOperation(account, amount);
        }
    }
}