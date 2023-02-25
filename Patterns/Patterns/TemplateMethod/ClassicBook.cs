namespace Patterns.TemplateMethod
{
    /// <summary>
    /// Classiс paper book.
    /// </summary>
    public class ClassicBook : ReadingService
    {
        /// <inheritdoc/>
        public override void BuyBook()
        {
            Console.WriteLine("Bought a classic book.");
        }

        /// <inheritdoc/>
        public override void RateBook()
        {
            Console.WriteLine("Rated a classic book.");
        }

        /// <inheritdoc/>
        public override void CloseBook()
        {
            Console.WriteLine("Closed a classic book.");
        }

        /// <inheritdoc/>
        public override void ReadBook()
        {
            Console.WriteLine("Read a classic book.");
        }
    }
}