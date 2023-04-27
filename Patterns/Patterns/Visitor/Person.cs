namespace Patterns.Visitor;

/// <summary>
/// Person who can count.
/// </summary>
internal class Person : IOperational
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class.
    /// </summary>
    /// <param name="numberA">First number.</param>
    /// <param name="numberB">Second number.</param>
    public Person(int numberA, int numberB)
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

    /// <inheritdoc/>
    public void Accept(IVisitor visitor)
    {
        visitor.VisitPerson(this);
    }
}
