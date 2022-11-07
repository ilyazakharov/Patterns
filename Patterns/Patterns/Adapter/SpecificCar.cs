namespace Patterns.Adapter
{
    /// <summary>
    /// Specifice car.
    /// </summary>
    public class SpecificCar : ICar
    {
        /// <inheritdoc/>
        public void Accelerate()
        {
            Console.WriteLine("Accelerating.");
        }

        /// <inheritdoc/>
        public void Drive()
        {
            Console.WriteLine("Starting to drive.");
        }

        /// <inheritdoc/>
        public void Stop()
        {
            Console.WriteLine("Stopping.");
        }
    }
}
