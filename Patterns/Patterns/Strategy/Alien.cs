namespace Patterns.Strategy
{
    /// <summary>
    /// An alien. Concrete stategy class.
    /// </summary>
    public class Alien : IDriver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Alien"/> class.
        /// </summary>
        /// <param name="name">Name of the human.</param>
        public Alien(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the name of the alien.
        /// </summary>
        public string Name { get; }

        /// <inheritdoc/>
        public void Shout()
        {
            Console.WriteLine($"{this.Name} zodijmkl fjkdo!");
        }
    }
}