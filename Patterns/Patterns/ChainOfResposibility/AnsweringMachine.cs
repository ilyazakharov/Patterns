namespace Patterns.ChainOfResposibility;

/// <summary>
/// Answering machine.
/// </summary>
internal class AnsweringMachine : IHandler
{
    /// <inheritdoc/>
    public IHandler? NextHandler { get; set; }

    /// <inheritdoc/>
    public void Handle(Request request)
    {
        if (request.Meaning == 1)
        {
            Console.WriteLine("Request was processed by answering machine");
            return;
        }

        this.NextHandler?.Handle(request);
    }
}
