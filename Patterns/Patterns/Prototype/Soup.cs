namespace Patterns.Prototype;

/// <summary>
/// Soup.
/// </summary>
internal class Soup : IDish
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Soup"/> class.
    /// </summary>
    /// <param name="name">Name of the soup.</param>
    public Soup(string name)
    {
        this.Name = name;
    }

    /// <summary>
    /// Gets the name of the soup.
    /// </summary>
    public string Name { get; }

    /// <inheritdoc/>
    public IDish Clone()
    {
        return new Soup(this.Name);
    }
}
