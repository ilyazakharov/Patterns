namespace Patterns.AbstractFactory.ComputerAccessories
{
    /// <summary>
    /// Asus motherboard.
    /// </summary>
    public class AsusMB : IMotherboard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsusMB"/> class.
        /// </summary>
        public AsusMB()
        {
            this.Name = "Asus prime A320";
            this.HasWiFi = false;
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public bool HasWiFi { get; }
    }
}