namespace Patterns.TemplateMethod
{
    /// <summary>
    /// Classiс paper book.
    /// </summary>
    public class ClassicBook : IReadingService
    {
        /// <inheritdoc/>
        public void BuyBook()
        {
            Console.WriteLine("Bought a classic book.");
        }

        /// <inheritdoc/>
        public void RateBook()
        {
            Console.WriteLine("Rated a classic book.");
        }

        /// <inheritdoc/>
        public void CloseBook()
        {
            Console.WriteLine("Closed a classic book.");
        }

        /// <inheritdoc/>
        public void ReadBook()
        {
            Console.WriteLine("Read a classic book.");
        }
    }
}