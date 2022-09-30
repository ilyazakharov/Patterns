namespace Patterns.Decorator
{
    /// <summary>
    /// Input monet operation.
    /// </summary>
    public class OutOperation : Operation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutOperation"/> class.
        /// </summary>
        /// <param name="extNumber">Number of the operation from exchange.</param>
        /// <param name="amount">Amount of the operation.</param>
        public OutOperation(string extNumber, decimal amount)
            : base(extNumber, amount, "Output money with ")
        {
        }
    }
}