namespace Patterns.AbstractFactory.ComputerAccessories
{
    /// <summary>
    /// Motherboard interface.
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Gets the name of the MB.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets a value indicating whether a wi-fi module presents on the MB.
        /// </summary>
        bool HasWiFi { get; }
    }
}