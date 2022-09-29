namespace Patterns.Strategy
{
    /// <summary>
    /// Fly with reactive engine behavour. Concrete stategy class.
    /// </summary>
    public class FlyWithReactiveEngine : IFlyBehavour
    {
        /// <inheritdoc/>
        public void Fly()
        {
            Console.WriteLine("Flying with reactive engine");
        }
    }
}