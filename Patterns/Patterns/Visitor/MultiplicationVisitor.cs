namespace Patterns.Visitor;

/// <summary>
/// Multiplication of numbers.
/// </summary>
internal class MultiplicationVisitor : IVisitor
{
    /// <inheritdoc/>
    public void VisitCalculator(Calculator computer)
    {
        Console.WriteLine($"The product of {computer.NumberA} and {computer.NumberB} computed by a сalculator is {computer.NumberA * computer.NumberB}");
    }

    /// <inheritdoc/>
    public void VisitPerson(Person person)
    {
        Console.WriteLine($"The product of {person.NumberA} and {person.NumberB} computed by a person is {(person.NumberA * person.NumberB) + 1}");
    }
}
