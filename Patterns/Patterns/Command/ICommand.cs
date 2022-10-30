namespace Patterns.Command
{
    /// <summary>
    /// Command interface.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes a command.
        /// </summary>
        void Execute();

        /// <summary>
        /// Undoing the last command.
        /// </summary>
        void Undo();

        /// <summary>
        /// Redoing the last command.
        /// </summary>
        void Redo();
    }
}
