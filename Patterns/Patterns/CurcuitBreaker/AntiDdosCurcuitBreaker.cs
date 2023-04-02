namespace Patterns.CurcuitBreaker;

/// <summary>
/// Curquit breaker used for not DDOS-ing services.
/// </summary>
internal class AntiDdosCurcuitBreaker : ICircuitBreaker
{
    private readonly int timeout;
    private DateTime openDate;
    private bool wasThronforTestPurposes = false;
    private CurquitBreakerStates state = CurquitBreakerStates.Closed;

    /// <summary>
    /// Initializes a new instance of the <see cref="AntiDdosCurcuitBreaker"/> class.
    /// </summary>
    /// <param name="timeout">Timeout.</param>
    public AntiDdosCurcuitBreaker(int timeout)
    {
        this.timeout = timeout;
    }

    /// <inheritdoc/>
    public void Execute(Action func)
    {
        this.wasThronforTestPurposes = false; // Only for testing.

        this.Guard();

        if (this.wasThronforTestPurposes) return; // Only for testing.

        try
        {
            func();
            this.Succeed();
        }
        catch (Exception e)
        {
            // You sould use here only exceptions that may be thrown by external source.
            this.Trip(e);
            Console.WriteLine("Thrown an exception in execute Catch."); // Use Throw; here
        }
    }

    private void Guard()
    {
        // It may be good to use state pattern for the real case.
        if (this.state is CurquitBreakerStates.Closed or CurquitBreakerStates.HalfOpen)
        {
            return;
        }

        if (this.openDate.AddSeconds(this.timeout) <= DateTime.Now)
        {
            this.state = CurquitBreakerStates.HalfOpen;
            Console.WriteLine("Timeout has passed. Trying to call an external source.");
            return;
        }

        Console.WriteLine("Thrown an exception in Guard."); // Use Throw; here
        this.wasThronforTestPurposes = true; // Only for testing.
    }

    private void Succeed()
    {
        this.state = CurquitBreakerStates.Closed;
    }

    private void Trip(Exception exception)
    {
        this.state = CurquitBreakerStates.Open;
        this.openDate = DateTime.Now;
    }
}
