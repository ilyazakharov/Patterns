using Patterns.Facade.FacadeExample;
using Patterns.Facade.Kitchen;

namespace Patterns.Facade.FactoryMethodForFacade
{
    /// <summary>
    /// Chicken with potatoes maker creator.
    /// </summary>
    public class ChickenWithPotatoesMakerCreator : IDishMakerCreator
    {
        /// <inheritdoc/>
        public IDishMakerFacade CreateDishMakerFacade()
        {
            Fridge fridge = new (5);
            fridge.AddProduct("chicken");
            fridge.AddProduct("potato");

            IDishMakerFacade facade = new ChickenWithPotatoesMaker(fridge, new Cutter(), new Mixer(), new Oven(200, OvenMode.HighAndLow));
            return facade;
        }
    }
}
