namespace Patterns.Strategy
{
    /// <summary>
    /// Conveyance.
    /// </summary>
    public abstract class Conveyance
    {
        private readonly int speed;

        /// <summary>
        /// Initializes a new instance of the <see cref="Conveyance"/> class.
        /// </summary>
        /// <param name="driver">Driver of the conveyance.</param>
        /// <param name="flyBehavour">Fly behavour of the conveyance.</param>
        /// <param name="speed">Speed of the conveyance.</param>
        public Conveyance(IDriver driver, IFlyBehavour flyBehavour, int speed)
        {
            this.Driver = driver;
            this.FlyBehavour = flyBehavour;
            this.speed = speed;
        }

        /// <summary>
        /// Gets or sets the driver of the conveyance (ASSOSIATION - AGGREGATION).
        /// </summary>
        public IDriver Driver { get; set; }

        /// <summary>
        /// Gets the fly behavour of the conveyance (ASSOSIATION - COMPOSITION).
        /// </summary>
        public IFlyBehavour FlyBehavour { get; }

        /// <summary>
        /// STRATEGY realization. Associoated driver shouts.
        /// </summary>
        public void ImplementShout()
        {
            this.Driver.Shout();
        }

        /// <summary>
        /// STRATEGY realization. Associoated flywing behavour.
        /// </summary>
        public void ImplementFly()
        {
            this.FlyBehavour.Fly();
        }

        /// <summary>
        /// Moving forward.
        /// </summary>
        public void MoveForward() => Console.WriteLine($"Moving forward with speed : {this.speed}");
    }
}