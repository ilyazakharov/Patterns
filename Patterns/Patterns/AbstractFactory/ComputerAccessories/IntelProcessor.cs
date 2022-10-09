namespace Patterns.AbstractFactory.ComputerAccessories
{
    /// <summary>
    /// Intel processor.
    /// </summary>
    public class IntelProcessor : IProcessor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntelProcessor"/> class.
        /// </summary>
        public IntelProcessor()
        {
            this.Name = "i5 11400";
            this.Rate = 4700;
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public int Rate { get; }
    }
}