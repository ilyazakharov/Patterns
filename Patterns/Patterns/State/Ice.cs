namespace Patterns.State
{
    /// <summary>
    /// Ice water state.
    /// </summary>
    internal class Ice : IWaterState
    {
        private static readonly Ice Instance = new ();

        private Ice()
        {
        }

        /// <summary>
        /// Instance of the singleton ice class.
        /// </summary>
        /// <returns>Ice singleton.</returns>
        public static Ice GetInstance() => Instance;

        /// <inheritdoc/>
        public void Freeze(Water water)
        {
            Console.WriteLine("The water is already frozen");
        }

        /// <inheritdoc/>
        public void Heat(Water water)
        {
            water.State = Liquid.GetInstance();
            Console.WriteLine("The ice became water");
        }
    }
}
