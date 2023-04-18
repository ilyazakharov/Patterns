namespace Patterns.Interpretor;

/// <summary>
/// Subtract one values from another.
/// </summary>
internal class SubtractExpression : IExpression
{
    private readonly IExpression subtractible;
    private readonly IExpression subtractor;

    /// <summary>
    /// Initializes a new instance of the <see cref="SubtractExpression"/> class.
    /// </summary>
    /// <param name="subtractible">Subtractible value.</param>
    /// <param name="subtractor">Subtractor.</param>
    public SubtractExpression(IExpression subtractible, IExpression subtractor)
    {
        this.subtractible = subtractible;
        this.subtractor = subtractor;
    }

    /// <inheritdoc/>
    public int Interpret(MathContext context)
    {
        return this.subtractible.Interpret(context) - this.subtractor.Interpret(context);
    }
}
