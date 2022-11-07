namespace Patterns.Facade.FacadeExample
{
    using Patterns.Facade.Kitchen;

    /// <summary>
    /// A maker that makes chicken with potatoes.
    /// </summary>
    public class ChickenWithPotatoesMaker : IDishMakerFacade
    {
        private readonly Fridge fridge;
        private readonly Cutter cutter;
        private readonly Mixer mixer;
        private readonly Oven oven;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChickenWithPotatoesMaker"/> class.
        /// </summary>
        /// <param name="fridge">Fridge.</param>
        /// <param name="cutter">Cutter.</param>
        /// <param name="mixer">Mixer.</param>
        /// <param name="oven">Oven.</param>
        public ChickenWithPotatoesMaker(Fridge fridge, Cutter cutter, Mixer mixer, Oven oven)
        {
            this.fridge = fridge;
            this.cutter = cutter;
            this.mixer = mixer;
            this.oven = oven;
        }

        /// <inheritdoc/>
        public string MakeDish()
        {
            if (!this.fridge.TakeProduct("chicken"))
            {
                return "No chicken";
            }

            if (!this.fridge.TakeProduct("potato"))
            {
                return "No potatoes";
            }

            List<string> products = new () { "chicken", "potato" };
            products = products.Select(p => this.cutter.Cut(p)).ToList();
            string result = this.mixer.Mix(products);
            result = this.oven.Cook(result);

            return result;
        }
    }
}
