namespace Patterns.Visitor;

/// <summary>
/// Calculator.
/// </summary>
internal class Calculator : IOperational
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Calculator"/> class.
    /// </summary>
    /// <param name="numberA">First number.</param>
    /// <param name="numberB">Second number.</param>
    public Calculator(int numberA, int numberB)
    {
        this.NumberA = numberA;
        this.NumberB = numberB;
    }

    /// <summary>
    /// Gets or sets a first number.
    /// </summary>
    public int NumberA { get; set; }

    /// <summary>
    /// Gets or sets a second number.
    /// </summary>
    public int NumberB { get; set; }

    /// <inheritdoc/>`
    public void Accept(IVisitor visitor)
    {
        visitor.VisitCalculator(this);
    }
}
