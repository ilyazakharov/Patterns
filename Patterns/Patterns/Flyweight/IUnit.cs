namespace Patterns.Flyweight;

/// <summary>
/// Unit interface.
/// </summary>
internal interface IUnit
{
    /// <summary>
    /// Unit strikes.
    /// </summary>
    /// <param name="strength">Strength of the unit.</param>
    void Strike(int strength);

    /// <summary>
    /// Unit moves.
    /// </summary>
    void Move();
}
