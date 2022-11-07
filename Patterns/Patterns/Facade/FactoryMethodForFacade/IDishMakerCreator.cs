namespace Patterns.Facade.FactoryMethodForFacade
{
    using Patterns.Facade.FacadeExample;

    /// <summary>
    /// Dish maker factory method.
    /// </summary>
    public interface IDishMakerCreator
    {
        /// <summary>
        /// Creates dish maker.
        /// </summary>
        /// <returns>Dish maker.</returns>
        public IDishMakerFacade CreateDishMakerFacade();
    }
}
