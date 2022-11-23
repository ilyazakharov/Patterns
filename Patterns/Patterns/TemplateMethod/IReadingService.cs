namespace Patterns.TemplateMethod
{
    /// <summary>
    /// Reading sevice interface.
    /// </summary>
    public interface IReadingService
    {
        /// <summary>
        /// Overall process for reading a book.
        /// </summary>
        void Process()
        {
            // Template method - sceleton of operations.
            this.BuyBook();
            this.ReadBook();
            this.CloseBook();
            this.RateBook();
        }

        /// <summary>
        /// Buy book.
        /// </summary>
        void BuyBook();

        /// <summary>
        /// Read book.
        /// </summary>
        void ReadBook();

        /// <summary>
        /// (Optional) Close book.
        /// </summary>
        void CloseBook()
        {

        }

        /// <summary>
        /// Rate book.
        /// </summary>
        void RateBook();
    }
}
