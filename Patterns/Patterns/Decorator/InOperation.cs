namespace Patterns.Decorator
{
    /// <summary>
    /// Input monet operation.
    /// </summary>
    public class InOperation : Operation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InOperation"/> class.
        /// </summary>
        /// <param name="extNumber">Number of the operation from exchange..</param>
        /// <param name="amount">Amount of the operation.</param>
        public InOperation(string extNumber, decimal amount)
            : base(extNumber, amount, "Input money with ")
        {
        }
    }
}