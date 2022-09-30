namespace Patterns.Decorator
{
    public class OperationDecorator : Operation
    {
        private Operation operation;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationDecorator"/> class.
        /// </summary>
        /// <param name="extNumber">Number of the operation from exchange.</param>
        /// <param name="amount">Amount of the operation.</param>
        /// <param name="operation">Operation for the decorator.</param>
        /// <param name="description">Description of the operation.</param>
        public OperationDecorator(string extNumber, decimal amount, string description, Operation operation)
            : base(extNumber, amount, description)
        {
            this.operation = operation;
        }
    }
}
