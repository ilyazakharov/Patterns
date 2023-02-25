namespace Patterns.TemplateMethod
{
    /// <summary>
    /// Electronic book.
    /// </summary>
    public class EBook : ReadingService
    {
        /// <inheritdoc/>
        public override void BuyBook()
        {
            Console.WriteLine("Bought an electronic book.");
        }

        /// <inheritdoc/>
        public override void RateBook()
        {
            Console.WriteLine("Rated an electronic book.");
        }

        /// <inheritdoc/>
        public override void ReadBook()
        {
            Console.WriteLine("Read an electronic book.");
        }
    }
}