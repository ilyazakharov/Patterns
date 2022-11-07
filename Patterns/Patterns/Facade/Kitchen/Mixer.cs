namespace Patterns.Facade.Kitchen
{
    /// <summary>
    /// A this for mixing ingredients.
    /// </summary>
    public class Mixer
    {
        /// <summary>
        /// Mixing products.
        /// </summary>
        /// <param name="products">Products that are needed to be mixed.</param>
        /// <returns>Name of the mixed products.</returns>
        public string Mix(List<string> products)
        {
            return string.Join(" with ", products);
        }
    }
}
