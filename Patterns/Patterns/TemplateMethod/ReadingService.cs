namespace Patterns.TemplateMethod
{
    /// <summary>
    /// Reading sevice abstract class.
    /// </summary>
    public abstract class ReadingService
    {
        /// <summary>
        /// Overall process for reading a book.
        /// </summary>
        public void Process()
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
        public abstract void BuyBook();

        /// <summary>
        /// Read book.
        /// </summary>
        public abstract void ReadBook();

        /// <summary>
        /// (Hook operation) Close book.
        /// </summary>
        public virtual void CloseBook()
        {
        }

        /// <summary>
        /// Rate book.
        /// </summary>
        public abstract void RateBook();
    }
}
