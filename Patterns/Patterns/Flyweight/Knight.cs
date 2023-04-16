namespace Patterns.Flyweight;

/// <summary>
/// Knoght unit.
/// </summary>
internal class Knight : IUnit
{
    private readonly int speed = 3;

    /// <inheritdoc/>
    public void Move()
    {
        Console.WriteLine($"Knight moves with speed {this.speed}");
    }

    /// <inheritdoc/>
    public void Strike(int strength)
    {
        Console.WriteLine($"Knight strikes with a sword with strength {strength}");
    }
}
