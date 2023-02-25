namespace Patterns.State
{
    /// <summary>
    /// Water state interface.
    /// </summary>
    internal interface IWaterState
    {
        /// <summary>
        /// Freeze the water.
        /// </summary>
        /// <param name="water">Water.</param>
        void Freeze(Water water);

        /// <summary>
        /// Heat the water.
        /// </summary>
        /// <param name="water">Water.</param>
        void Heat(Water water);
    }
}
