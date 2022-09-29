namespace Patterns.Observer
{
    /// <summary>
    /// Observable interface.
    /// </summary>
    public interface IObservable
    {
        /// <summary>
        /// Adding new listener.
        /// </summary>
        /// <param name="observer">Listener.</param>
        void AddListener(IObserver observer);

        /// <summary>
        /// Deleting listener.
        /// </summary>
        /// <param name="observer">Listener.</param>
        void RemoveListener(IObserver observer);
    }
}
