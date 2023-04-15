namespace Patterns.ChainOfResposibility;

/// <summary>
/// Call center.
/// </summary>
internal class CallCenter : IHandler
{
    /// <inheritdoc/>
    public IHandler? NextHandler { get; set; }

    /// <inheritdoc/>
    public void Handle(Request request)
    {
        if (request.Meaning == 2)
        {
            Console.WriteLine("Request was processed by call center");
            return;
        }

        this.NextHandler?.Handle(request);
    }
}
