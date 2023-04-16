namespace Patterns.Flyweight;

/// <summary>
/// Unit factory.
/// </summary>
internal class UnitFactory
{
    private Dictionary<string, IUnit> unitSet = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitFactory"/> class.
    /// </summary>
    public UnitFactory()
    {
        this.unitSet.Add("Archer", new Archer());
        this.unitSet.Add("Knight", new Knight());
    }

    /// <summary>
    /// Gets a unit.
    /// </summary>
    /// <param name="name">Name of the unit.</param>
    /// <returns>Unit if exists.</returns>
    public IUnit? GetUnit(string name)
    {
        if (this.unitSet.ContainsKey(name))
        {
            return this.unitSet[name];
        }

        // You can define some null object here so the method can return non-nullable object
        return null;
    }
}
