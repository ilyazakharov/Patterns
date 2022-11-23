namespace Patterns.TemplateMethod
{
    /// <summary>
    /// Electronic book.
    /// </summary>
    public class EBook : IReadingService
    {
        /// <inheritdoc/>
        public void BuyBook()
        {
            Console.WriteLine("Bought an electronic book.");
        }

        /// <inheritdoc/>
        public void RateBook()
        {
            Console.WriteLine("Rated an electronic book.");
        }

        /// <inheritdoc/>
        public void ReadBook()
        {
            Console.WriteLine("Read an electronic book.");
        }
    }
}