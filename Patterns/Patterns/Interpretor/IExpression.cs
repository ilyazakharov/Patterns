namespace Patterns.Interpretor;

/// <summary>
/// Interface for math expressions.
/// </summary>
internal interface IExpression
{
    /// <summary>
    /// Interpret command.
    /// </summary>
    /// <param name="context">Math context.</param>
    /// <returns>Result of the interpretation.</returns>
    int Interpret(MathContext context);
}
