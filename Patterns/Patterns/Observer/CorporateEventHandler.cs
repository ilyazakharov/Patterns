namespace Patterns.Observer
{
    /// <summary>
    /// Handler of issuers corporate events.
    /// </summary>
    public class CorporateEventHandler : IObservable
    {
        private readonly List<IObserver> observers;

        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateEventHandler"/> class.
        /// </summary>
        public CorporateEventHandler()
        {
            this.observers = new List<IObserver>();
        }

        /// <summary>
        /// Gets data about event.
        /// </summary>
        public string? Data { get; private set; }

        /// <summary>
        /// Gets value of the event.
        /// </summary>
        public int? Value { get; private set; }

        /// <summary>
        /// Processing data.
        /// </summary>
        /// <param name="data">Input data.</param>
        public void ProcessData(string data, int value)
        {
            this.Data = data;
            this.Value = value;

            this.observers.ForEach(x => x.Update(this));
        }

        /// <inheritdoc/>
        public void AddListener(IObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <inheritdoc/>
        public void RemoveListener(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }
}
