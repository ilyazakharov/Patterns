namespace Patterns.Interpretor;

/// <summary>
/// Add two values.
/// </summary>
internal class AddExpression : IExpression
{
    private readonly IExpression firstSummand;
    private readonly IExpression secondSummand;

    /// <summary>
    /// Initializes a new instance of the <see cref="AddExpression"/> class.
    /// </summary>
    /// <param name="firstSummand">First operand.</param>
    /// <param name="secondSummand">Second operand.</param>
    public AddExpression(IExpression firstSummand, IExpression secondSummand)
    {
        this.firstSummand = firstSummand;
        this.secondSummand = secondSummand;
    }

    /// <inheritdoc/>
    public int Interpret(MathContext context)
    {
        return this.firstSummand.Interpret(context) + this.secondSummand.Interpret(context);
    }
}
