namespace Patterns.ChainOfResposibility;

/// <summary>
/// Null handler.
/// </summary>
internal class Unprocessable : IHandler
{
    /// <inheritdoc/>
    public IHandler? NextHandler { get; set; }

    /// <inheritdoc/>
    public void Handle(Request request)
    {
        Console.WriteLine("Request cannot be processed!");
    }
}
