namespace Patterns.Observer
{
    /// <summary>
    /// Class that needs to get the updated data.
    /// </summary>
    public class Bank : IObserver
    {
        private readonly string name;
        private readonly List<int> values = new List<int>();
        private readonly IObservable observable;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bank"/> class.
        /// </summary>
        /// <param name="name">Bank name.</param>
        /// <param name="observable">IObservable object.</param>
        public Bank(string name, IObservable observable)
        {
            this.name = name;
            this.observable = observable;
            this.observable.AddListener(this);
        }

        /// <summary>
        /// Removing bank from listeners.
        /// </summary>
        public void StopListening()
        {
            this.observable.RemoveListener(this);
        }

        /// <inheritdoc/>
        public void Update(IObservable observable)
        {
            if (observable is CorporateEventHandler corporateEventHandler)
            {
                if (corporateEventHandler.Value != 0)
                {
                    this.values.Add(corporateEventHandler.Value ?? 0);
                }
            }

            this.Show();
        }

        private void Show()
        {
            var avg = this.values.Count == 0 ? 0 : this.values.Sum() / this.values.Count;
            Console.WriteLine($"Bank name : {this.name}, average value : {avg}");
        }
    }
}
