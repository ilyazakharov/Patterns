namespace Patterns.Facade.FacadeExample
{
    /// <summary>
    /// Dish maker interface.
    /// </summary>
    public interface IDishMakerFacade
    {
        /// <summary>
        /// Makes a new dish.
        /// </summary>
        /// <returns>Name of the dish.</returns>
        string MakeDish();
    }
}
