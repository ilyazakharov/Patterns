namespace Patterns.Visitor;

/// <summary>
/// Operations interface for visitor.
/// </summary>
internal interface IOperational
{
    /// <summary>
    /// Do something with visitor functionality.
    /// </summary>
    /// <param name="visitor">Visitor.</param>
    void Accept(IVisitor visitor);
}
