namespace Patterns.FactoryMethod
{
    /// <summary>
    /// Money operation.
    /// </summary>
    public class MoneyOperation : Oper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyOperation"/> class.
        /// </summary>
        /// <param name="account">Account for the operation.</param>
        /// <param name="amount">Amount of the operation.</param>
        public MoneyOperation(string account, decimal amount)
            : base(account + "-MONEY", amount)
        {
        }
    }
}
