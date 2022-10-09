namespace Patterns.AbstractFactory.ComputerAccessories
{
    /// <summary>
    /// AMD processor.
    /// </summary>
    public class AMDProcessor : IProcessor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AMDProcessor"/> class.
        /// </summary>
        public AMDProcessor()
        {
            this.Name = "AMD 5600";
            this.Rate = 4300;
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public int Rate { get; }
    }
}