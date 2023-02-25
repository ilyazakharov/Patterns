namespace Patterns.State
{
    /// <summary>
    /// Water class.
    /// </summary>
    public class Water
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Water"/> class.
        /// </summary>
        /// <param name="tempreature">Tempretare of the water.</param>
        public Water(int tempreature)
        {
            this.State = tempreature switch
            {
                < 0 => Ice.GetInstance(),
                < 100 => Liquid.GetInstance(),
                _ => Gas.GetInstance()
            };
        }

        /// <summary>
        /// Sets the state of the water.
        /// </summary>
        internal IWaterState State { private get; set; }

        /// <summary>
        /// Heat the water.
        /// </summary>
        public void Heat()
        {
            this.State.Heat(this);
        }


        /// <summary>
        /// Freeze the water.
        /// </summary>
        public void Freeze()
        {
            this.State.Freeze(this);
        }
    }
}
