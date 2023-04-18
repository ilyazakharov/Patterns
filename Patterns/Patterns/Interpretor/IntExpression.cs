namespace Patterns.Interpretor;

/// <summary>
/// Integer value.
/// </summary>
internal class IntExpression : IExpression
{
    private readonly string name;

    /// <summary>
    /// Initializes a new instance of the <see cref="IntExpression"/> class.
    /// </summary>
    /// <param name="name">Name of the variable.</param>
    public IntExpression(string name)
    {
        this.name = name;
    }

    /// <inheritdoc/>
    public int Interpret(MathContext context)
    {
        return context.GetValue(this.name);
    }
}

