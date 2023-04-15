namespace Patterns.ChainOfResposibility;

/// <summary>
/// Handler inteface.
/// </summary>
internal interface IHandler
{
    /// <summary>
    /// Gets or sets the next handler.
    /// </summary>
    IHandler? NextHandler { get; set; }

    /// <summary>
    /// Handle request.
    /// </summary>
    /// <param name="request">Client's request.</param>
    void Handle(Request request);
}
