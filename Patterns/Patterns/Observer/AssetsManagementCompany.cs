namespace Patterns.Observer
{
    /// <summary>
    /// Class that needs to get the updated data.
    /// </summary>
    public class AssetsManagementCompany : IObserver
    {
        private readonly string name;
        private readonly IObservable observable;
        private string? data;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsManagementCompany"/> class.
        /// </summary>
        /// <param name="name">Company name.</param>
        /// <param name="observable">IObservable object.</param>
        public AssetsManagementCompany(string name, IObservable observable)
        {
            this.name = name;
            this.observable = observable;
            this.observable.AddListener(this);
        }

        /// <inheritdoc/>
        public void Update(IObservable observable)
        {
            if (observable is CorporateEventHandler corporateEventHandler)
            {
                this.data = corporateEventHandler.Data;
            }

            this.Show();
        }

        private void Show() => Console.WriteLine($"Company name : {this.name}, data : {this.data}");
    }
}
