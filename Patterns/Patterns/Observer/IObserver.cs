namespace Patterns.Observer
{
    /// <summary>
    /// Observer interface.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Reaction to new event.
        /// </summary>
        /// <param name="observable">IObservable object.</param>
        void Update(IObservable observable);
    }
}
