namespace Patterns.Adapter
{
    /// <summary>
    /// Plane interface.
    /// </summary>
    public interface IPlane
    {
        /// <summary>
        /// Begins to fly.
        /// </summary>
        void BeginToFly();

        /// <summary>
        /// Landing.
        /// </summary>
        void Land();

        /// <summary>
        /// Go higher.
        /// </summary>
        void IncreaseAltitude();
    }
}
