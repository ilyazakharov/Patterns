namespace Patterns.ChainOfResposibility;

/// <summary>
/// Support.
/// </summary>
internal class Support : IHandler
{
    /// <inheritdoc/>
    public IHandler? NextHandler { get; set; }

    /// <inheritdoc/>
    public void Handle(Request request)
    {
        if (request.Meaning == 3)
        {
            Console.WriteLine("Request was processed by support");
            return;
        }

        this.NextHandler?.Handle(request);
    }
}
