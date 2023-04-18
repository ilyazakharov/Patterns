namespace Patterns.Interpretor;

/// <summary>
/// Context for math operations.
/// </summary>
internal class MathContext
{
    private Dictionary<string, int> values = new();

    /// <summary>
    /// Sets a new variable.
    /// </summary>
    /// <param name="name">Name of the variable.</param>
    /// <param name="value">Value of the variable.</param>
    public void SetValue(string name, int value)
    {
        if (this.values.ContainsKey(name))
        {
            this.values.Add(name, value);
        }
        else
        {
            this.values[name] = value;
        }
    }

    /// <summary>
    /// Gets a value of the variable.
    /// </summary>
    /// <param name="name">Name of the variable.</param>
    /// <returns>Value of the variable.</returns>
    public int GetValue(string name)
    {
        return this.values[name];
    }
}
