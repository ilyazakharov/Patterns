namespace Patterns.CurcuitBreaker;

/// <summary>
/// Curcuit breaker interface.
/// </summary>
internal interface ICircuitBreaker
{
    /// <summary>
    /// Executes lambda preparing it with curcuit breaker.
    /// </summary>
    /// <typeparam name="T">Type.</typeparam>
    /// <param name="func">Lambda.</param>
    void Execute(Action func);
}