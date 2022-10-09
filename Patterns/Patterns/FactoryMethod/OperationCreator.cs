namespace Patterns.FactoryMethod
{
    /// <summary>
    /// Abstract operation creator.
    /// </summary>
    public abstract class OperationCreator
    {
        /// <summary>
        /// Creates new operation.
        /// </summary>
        /// <param name="account">Account for the operation.</param>
        /// <param name="amount">Amount of the operation.</param>
        /// <returns>New operation.</returns>
        public abstract Oper CreateOperation(string account, decimal amount);
    }
}
