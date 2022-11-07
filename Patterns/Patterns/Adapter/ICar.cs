namespace Patterns.Adapter
{
    /// <summary>
    /// Car interface.
    /// </summary>
    public interface ICar
    {
        /// <summary>
        /// Starts to drive a car.
        /// </summary>
        void Drive();

        /// <summary>
        /// Accelerates a car.
        /// </summary>
        void Accelerate();

        /// <summary>
        /// Stops a car.
        /// </summary>
        void Stop();
    }
}
