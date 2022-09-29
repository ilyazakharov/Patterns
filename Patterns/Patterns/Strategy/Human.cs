namespace Patterns.Strategy
{
    /// <summary>
    /// A human being. Concrete stategy class.
    /// </summary>
    public class Human : IDriver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Human"/> class.
        /// </summary>
        /// <param name="name">Name of the human.</param>
        public Human(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the name of the human.
        /// </summary>
        public string Name { get; }

        /// <inheritdoc/>
        public void Shout()
        {
            Console.WriteLine($"What the heck! My name is {this.Name}");
        }
    }
}