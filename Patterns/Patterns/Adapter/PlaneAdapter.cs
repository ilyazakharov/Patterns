namespace Patterns.Adapter
{
    /// <summary>
    /// Plane adapter for ICar interface.
    /// </summary>
    public class PlaneAdapter : ICar
    {
        private readonly IPlane plane;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaneAdapter"/> class.
        /// </summary>
        /// <param name="plane">A specific plane.</param>
        public PlaneAdapter(IPlane plane)
        {
            this.plane = plane;
        }

        /// <inheritdoc/>
        public void Accelerate()
        {
            this.plane.IncreaseAltitude();
        }

        /// <inheritdoc/>
        public void Drive()
        {
            this.plane.BeginToFly();
        }

        /// <inheritdoc/>
        public void Stop()
        {
            this.plane.Land();
        }
    }
}
