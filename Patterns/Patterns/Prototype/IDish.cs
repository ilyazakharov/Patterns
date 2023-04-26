namespace Patterns.Prototype;

/// <summary>
/// Dish.
/// </summary>
internal interface IDish
{
    /// <summary>
    /// Gets the name of the soup.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Clones a dish.
    /// </summary>
    /// <returns>New dish.</returns>
    IDish Clone();
}
