namespace Patterns.Decorator
{
    /// <summary>
    /// Decorator for the operation to add commission.
    /// </summary>
    public class OperWithCommission : OperationDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperWithCommission"/> class.
        /// </summary>
        /// <param name="operation">Operation to be decorated.</param>
        public OperWithCommission(Operation operation)
            : base(operation.ExtNumber, operation.Amount * 1.1m, operation.Description, operation)
        {
        }
    }
}