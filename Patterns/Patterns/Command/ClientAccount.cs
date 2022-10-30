namespace Patterns.Command
{
    /// <summary>
    /// Client's account.
    /// </summary>
    public class ClientAccount
    {
        private int quantity;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAccount"/> class.
        /// </summary>
        /// <param name="code">Client's code.</param>
        /// <param name="quantity">Client's quantity.</param>
        public ClientAccount(string code, int quantity)
        {
            this.Code = code;
            this.quantity = quantity;
            this.ClientIsAShorter = quantity < 0;
        }

        /// <summary>
        /// Gets or sets the client's code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the client's quantity.
        /// </summary>
        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                this.ClientIsAShorter = value < 0;
                this.quantity = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether a client has a debt.
        /// </summary>
        public bool ClientIsAShorter { get; private set; }

        /// <inheritdoc/>
        public override string? ToString()
        {
            return $"Client's account {this.Code}\n" +
                $"quantity: {this.Quantity},\n" +
                $"client is a shorter: {this.ClientIsAShorter}.\n";
        }
    }
}
