namespace Patterns.Builder;

/// <summary>
/// House builder.
/// </summary>
internal class HouseBuilder
{
    private bool hasMedievalFacade;
    private bool hasOuthouse;
    private bool hasPark;

    /// <summary>
    /// Build new house.
    /// </summary>
    /// <returns>Builded house.</returns>
    public House Build()
    {
        return new House(this.hasMedievalFacade, this.hasOuthouse, this.hasPark);
    }

    /// <summary>
    /// House should have medieva facad.
    /// </summary>
    /// <returns>House builder.</returns>
    public HouseBuilder WithMedievalFacade()
    {
        this.hasMedievalFacade = true;
        return this;
    }

    /// <summary>
    /// House should have small outhouse.
    /// </summary>
    /// <returns>House builder.</returns>
    public HouseBuilder WithOuthouse()
    {
        this.hasOuthouse = true;
        return this;
    }

    /// <summary>
    /// There should be a park nearby.
    /// </summary>
    /// <returns>House builder.</returns>
    public HouseBuilder WithPark()
    {
        this.hasPark = true;
        return this;
    }
}
