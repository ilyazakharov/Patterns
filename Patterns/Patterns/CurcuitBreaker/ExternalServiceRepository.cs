namespace Patterns.CurcuitBreaker;

/// <summary>
/// Some external repository.
/// </summary>
internal class ExternalServiceRepository
{
    /// <summary>
    /// Gets or sets a value indicating whether repository should throw an exception.
    /// </summary>
    public bool ShouldThrow { get; set; }

    /// <summary>
    /// Does some work.
    /// </summary>
    public void DoSomeWork()
    {
        if (this.ShouldThrow)
        {
            throw new Exception();
        }

        Console.WriteLine("Did some work.");
    }
}
