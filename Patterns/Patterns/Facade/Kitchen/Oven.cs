namespace Patterns.Facade.Kitchen
{
    /// <summary>
    /// Oven modes enumerator.
    /// </summary>
    public enum OvenMode
    {
        /// <summary>
        /// High level heating.
        /// </summary>
        HighOnly,

        /// <summary>
        /// Loe level heating.
        /// </summary>
        LowOnly,

        /// <summary>
        /// Both levels heating.
        /// </summary>
        HighAndLow,
    }

    /// <summary>
    /// Electric oven.
    /// </summary>
    public class Oven
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oven"/> class.
        /// </summary>
        /// <param name="temperature">Temperature.</param>
        /// <param name="mode">Heating mode.</param>
        public Oven(int temperature, OvenMode mode)
        {
            this.Temperature = temperature;
            this.Mode = mode;
        }

        /// <summary>
        /// Gets or sets the oven temperature.
        /// </summary>
        public int Temperature { get; set; }

        /// <summary>
        /// Gets or sets oven mode.
        /// </summary>
        public OvenMode Mode { get; set; }

        /// <summary>
        /// Cookes a product.
        /// </summary>
        /// <param name="product">Prduct that should be cooked.</param>
        /// <returns>Name of the prepared dish.</returns>
        public string Cook(string product)
        {
            return $"{product} cooked with temperature = {this.Temperature} degrees on {this.Mode} mode.";
        }
    }
}
