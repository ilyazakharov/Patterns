namespace Patterns.Strategy
{
    /// <summary>
    /// Inability to fly behavour. Concrete stategy class.
    /// </summary>
    public class NotFlying : IFlyBehavour
    {
        /// <inheritdoc/>
        public void Fly()
        {
            Console.WriteLine("Can't fly");
        }
    }
}