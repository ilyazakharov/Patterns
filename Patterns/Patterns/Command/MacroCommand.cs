namespace Patterns.Command
{
    /// <summary>
    /// Makes serveral commands.
    /// </summary>
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> commands;
        private readonly List<ICommand> undoCommands;

        /// <summary>
        /// Initializes a new instance of the <see cref="MacroCommand"/> class.
        /// </summary>
        /// <param name="commands">Commands</param>
        public MacroCommand(List<ICommand> commands, List<ICommand> undoCommands)
        {
            this.commands = commands;
            this.undoCommands = undoCommands;
        }

        /// <inheritdoc/>
        public void Execute()
        {
            foreach (var command in this.commands)
            {
                command.Execute();
            }
        }

        /// <inheritdoc/>
        public void Redo()
        {
            foreach (var command in this.commands)
            {
                command.Redo();
            }
        }

        /// <inheritdoc/>
        public void Undo()
        {
            foreach (var command in this.undoCommands)
            {
                command.Undo();
            }
        }
    }
}
