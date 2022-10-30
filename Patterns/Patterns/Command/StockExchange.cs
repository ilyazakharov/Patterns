using System;

namespace Patterns.Command
{
    /// <summary>
    /// Stock exchange.
    /// </summary>
    public class StockExchange
    {
        private readonly Stack<ICommand> executed = new ();

        /// <summary>
        /// Initializes a new instance of the <see cref="StockExchange"/> class.
        /// </summary>
        /// <param name="sellCommands">List of commands for selling.</param>
        /// <param name="buyCommands">List of commands fo buying.</param>
        public StockExchange(List<ICommand> sellCommands, List<ICommand> buyCommands)
        {
            this.SellCommands = sellCommands == null ? new List<ICommand>() : sellCommands;
            this.BuyCommands = buyCommands == null ? new List<ICommand>() : buyCommands;
        }

        /// <summary>
        /// Gets the list of commands for selling.
        /// </summary>
        public List<ICommand> SellCommands { get; }

        /// <summary>
        /// Gets the list of commands fo buying.
        /// </summary>
        public List<ICommand> BuyCommands { get; }

        /// <summary>
        /// Sells stocks from a client account.
        /// </summary>
        /// <param name="index">Index of the selling command.</param>
        public void Sell(int index)
        {
            if (this.SellCommands.Count > index)
            {
                this.SellCommands[index].Execute();
                this.executed.Push(this.SellCommands[index]);
            }
            else
            {
                Console.WriteLine($"Wrong index {index}");
            }
        }


        /// <summary>
        /// Buys stocks from a client account.
        /// </summary>
        /// <param name="index">Index of the selling command.</param>
        public void Buy(int index)
        {
            if (this.BuyCommands.Count > index)
            {
                this.BuyCommands[index].Execute();
                this.executed.Push(this.BuyCommands[index]);
            }
            else
            {
                Console.WriteLine($"Wrong index {index}");
            }
        }

        /// <summary>
        /// Redoing the last command.
        /// </summary>
        public void Redo()
        {
            if (this.executed.TryPeek(out ICommand? redo))
            {
                redo.Redo();
                this.executed.Push(redo);
            }
        }

        /// <summary>
        /// Undoing the last command.
        /// </summary>
        public void Undo()
        {
            if (this.executed.TryPop(out ICommand? undo))
            {
                undo.Undo();
            }
        }
    }
}
