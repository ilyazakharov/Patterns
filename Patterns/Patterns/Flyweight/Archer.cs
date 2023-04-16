namespace Patterns.Flyweight;

/// <summary>
/// Archer unit.
/// </summary>
internal class Archer : IUnit
{
    private readonly int speed = 10;

    /// <inheritdoc/>
    public void Move()
    {
        Console.WriteLine($"Archer moves with speed {this.speed}");
    }

    /// <inheritdoc/>
    public void Strike(int strength)
    {
        Console.WriteLine($"Archer shoots with strength {strength}");
    }
}
