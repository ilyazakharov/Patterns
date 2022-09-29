namespace Patterns.Strategy
{
    /// <summary>
    /// Car.
    /// </summary>
    public class Car : Conveyance
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public Car(IDriver driver)
            : base(driver, new NotFlying(), 180)
        {
        }
    }
}