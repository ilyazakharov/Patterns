namespace Patterns.Visitor;

/// <summary>
/// Visitor.
/// </summary>
internal interface IVisitor
{
    /// <summary>
    /// Visit a person.
    /// </summary>
    /// <param name="person">Person.</param>
    void VisitPerson(Person person);

    /// <summary>
    /// Visit a сalculator.
    /// </summary>
    /// <param name="computer">Calculator.</param>
    void VisitCalculator(Calculator computer);
}
