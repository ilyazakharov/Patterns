namespace Patterns.Strategy
{
    /// <summary>
    /// Plane.
    /// </summary>
    public class Plane : Conveyance
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public Plane(IDriver driver)
            : base(driver, new FlyWithReactiveEngine(), 1580)
        {
        }
    }
}