namespace Patterns.State
{
    /// <summary>
    /// Gas water state.
    /// </summary>
    internal class Gas : IWaterState
    {
        private static readonly Gas Instance = new ();

        private Gas()
        {
        }

        /// <summary>
        /// Instance of the singleton gas class.
        /// </summary>
        /// <returns>Gas singleton.</returns>
        public static Gas GetInstance() => Instance;

        /// <inheritdoc/>
        public void Freeze(Water water)
        {
            water.State = Liquid.GetInstance();
            Console.WriteLine("The gas became water");
        }

        /// <inheritdoc/>
        public void Heat(Water water)
        {
            Console.WriteLine("The water was already boiled");
        }
    }
}
