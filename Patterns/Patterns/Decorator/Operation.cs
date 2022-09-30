namespace Patterns.Decorator
{
    /// <summary>
    /// Money operation.
    /// </summary>
    public abstract class Operation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Operation"/> class.
        /// </summary>
        /// <param name="extNumber">Number of the operation from exchange.</param>
        /// <param name="amount">Amount of the operation.</param>
        /// <param name="description">Description of the operation.</param>
        protected Operation(string extNumber, decimal amount, string description)
        {
            this.ExtNumber = extNumber;
            this.Amount = amount;
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets number of the operation from exchange.
        /// </summary>
        public string ExtNumber { get; set; }

        /// <summary>
        /// Gets or sets amount of the operation.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets description of the operation.
        /// </summary>
        public string Description { get; set; }
    }
}