namespace Patterns.AbstractFactory.ComputerAccessories
{
    /// <summary>
    /// Gygabyte motherboard.
    /// </summary>
    public class GygabyteMB : IMotherboard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GygabyteMB"/> class.
        /// </summary>
        public GygabyteMB()
        {
            Name = "Gygabyte Z690";
            HasWiFi = true;
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public bool HasWiFi { get; }
    }
}