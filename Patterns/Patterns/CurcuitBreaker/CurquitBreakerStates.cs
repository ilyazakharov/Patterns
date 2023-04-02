namespace Patterns.CurcuitBreaker;

/// <summary>
/// Ciruit breaker states.
/// </summary>
internal enum CurquitBreakerStates
{
    /// <summary>
    /// Closed state/.
    /// </summary>
    Closed = 0,

    /// <summary>
    /// Opern state.
    /// </summary>
    Open = 1,

    /// <summary>
    /// Half-open state.
    /// </summary>
    HalfOpen = 2,
}
