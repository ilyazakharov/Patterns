namespace Patterns.Facade.Kitchen
{
    /// <summary>
    /// A thing to cut ingredients.
    /// </summary>
    public class Cutter
    {
        /// <summary>
        /// Cutting products.
        /// </summary>
        /// <param name="product">Product that is needed to be cut./</param>
        /// <returns>Cutted product.</returns>
        public string Cut(string product)
        {
            return $"Cutted {product}";
        }
    }
}
