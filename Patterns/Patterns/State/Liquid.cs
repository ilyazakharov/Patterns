namespace Patterns.State
{
    /// <summary>
    /// Liquid water state.
    /// </summary>
    internal class Liquid : IWaterState
    {
        private static readonly Liquid Instance = new ();

        private Liquid()
        {
        }

        /// <summary>
        /// Instance of the singleton liquid class.
        /// </summary>
        /// <returns>Liquid singleton.</returns>
        public static Liquid GetInstance() => Instance;

        /// <inheritdoc/>
        public void Freeze(Water water)
        {
            water.State = Ice.GetInstance();
            Console.WriteLine("The water was freezed");
        }

        /// <inheritdoc/>
        public void Heat(Water water)
        {
            water.State = Gas.GetInstance();
            Console.WriteLine("The water became gas");
        }
    }
}
