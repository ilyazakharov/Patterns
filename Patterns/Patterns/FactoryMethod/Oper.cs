namespace Patterns.FactoryMethod
{
    /// <summary>
    /// Operations.
    /// </summary>
    public abstract class Oper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oper"/> class.
        /// </summary>
        /// <param name="account">Account for the operation.</param>
        /// <param name="amount">Amount of the operation.</param>
        protected Oper(string account, decimal amount)
        {
            this.Account = account;
            this.Amount = amount;
        }


        /// <summary>
        /// Gets or sets the account for the operation.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the amount of the operation.
        /// </summary>
        public decimal Amount { get; set; }

        /// <inheritdoc/>
        public override string? ToString()
        {
            return $"Account:{this.Account}, amount:{this.Amount}";
        }
    }
}
