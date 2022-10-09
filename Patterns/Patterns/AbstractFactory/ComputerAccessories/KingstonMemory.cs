namespace Patterns.AbstractFactory.ComputerAccessories
{
    /// <summary>
    /// Kingston memory.
    /// </summary>
    public class KingstonMemory : IMemory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KingstonMemory"/> class.
        /// </summary>
        public KingstonMemory()
        {
            this.Name = "Kingston 3200";
            this.Capacity = 16;
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public int Capacity { get; }
    }
}