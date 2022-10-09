namespace Patterns.AbstractFactory
{
    using Patterns.AbstractFactory.ComputerAccessories;

    /// <summary>
    /// Computer accessories factory interface.
    /// </summary>
    public interface IComputerAccessoriesFactory
    {
        /// <summary>
        /// Creates a new processor.
        /// </summary>
        /// <returns>New processor.</returns>
        IProcessor CreateProcessor();

        /// <summary>
        /// Creates a new MB.
        /// </summary>
        /// <returns>New MB.</returns>
        IMotherboard CreateMotherboard();
    }
}