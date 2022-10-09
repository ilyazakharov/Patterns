namespace Patterns.AbstractFactory
{
    using Patterns.AbstractFactory.ComputerAccessories;

    /// <summary>
    /// Computer.
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Computer"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="factory">Accessories factory for creating a processor and a MB.</param>
        /// <param name="memory">Memory.</param>
        public Computer(IComputerAccessoriesFactory factory, string name, IMemory memory)
        {
            this.Name = name;
            this.Processor = factory.CreateProcessor();
            this.Motherboard = factory.CreateMotherboard();
            this.Memory = memory;
        }

        /// <summary>
        /// Gets the name of the computer.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the processor of the computer.
        /// </summary>
        public IProcessor Processor { get; }

        /// <summary>
        /// Gets the MB of the computer.
        /// </summary>
        public IMotherboard Motherboard { get; }

        /// <summary>
        /// Gets a computer memory.
        /// </summary>
        public IMemory Memory { get; }

        /// <summary>
        /// Description.
        /// </summary>
        /// <returns>Description of the computer.</returns>
        public string Description() => $"{this.Name} (" +
                $"{this.Processor.Name} ({this.Processor.Rate}MHz), " +
                $"{this.Motherboard.Name} (WiFi:{this.Motherboard.HasWiFi}), " +
                $"{this.Memory.Name} ({this.Memory.Capacity}GB)" +
            ")";
    }
}