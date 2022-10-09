namespace Patterns.AbstractFactory.ComputerAccessories
{
    /// <summary>
    /// Computer memory.
    /// </summary>
    public interface IMemory
    {
        /// <summary>
        /// Gets the name of the memory.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the capacity of the memory.
        /// </summary>
        int Capacity { get; }
    }
}