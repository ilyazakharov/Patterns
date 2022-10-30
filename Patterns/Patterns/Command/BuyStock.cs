namespace Patterns.Command
{
    /// <summary>
    /// Selling stocks.
    /// </summary>
    public class BuyStock : ICommand
    {
        private readonly ClientAccount clientAccount;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyStock"/> class.
        /// </summary>
        /// <param name="clientAccount">Client's account.</param>
        public BuyStock(ClientAccount clientAccount)
        {
            this.clientAccount = clientAccount;
        }

        /// <inheritdoc/>
        public void Execute()
        {
            this.clientAccount.Quantity += 1;
        }

        /// <inheritdoc/>
        public void Redo()
        {
            this.Execute();
        }

        /// <inheritdoc/>
        public void Undo()
        {
            this.clientAccount.Quantity -= 1;
        }
    }
}
