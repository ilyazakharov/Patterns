namespace Patterns.AbstractFactory.ComputerAccessories
{
    /// <summary>
    /// Processor interface.
    /// </summary>
    public interface IProcessor
    {
        /// <summary>
        /// Gets the name of the processor.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the rate of the procssor.
        /// </summary>
        int Rate { get; }
    }
}