namespace Patterns.Adapter
{
    /// <summary>
    /// Specific plane.
    /// </summary>
    public class SpecificPlane : IPlane
    {
        /// <inheritdoc/>
        public void BeginToFly()
        {
            Console.WriteLine("Beginning to fly.");
        }

        /// <inheritdoc/>
        public void IncreaseAltitude()
        {
            Console.WriteLine("Going higher.");
        }

        /// <inheritdoc/>
        public void Land()
        {
            Console.WriteLine("Landing.");
        }
    }
}
