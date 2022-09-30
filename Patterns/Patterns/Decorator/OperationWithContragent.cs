namespace Patterns.Decorator
{
    /// <summary>
    /// Decorator to add a contragent to the operation.
    /// </summary>
    public class OperationWithContragent : OperationDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationWithContragent"/> class.
        /// </summary>
        /// <param name="operation">Operation to be decorated.</param>
        public OperationWithContragent(Operation operation)
            : base(operation.ExtNumber + "-CONTR", operation.Amount, operation.Description, operation)
        {
        }
    }
}