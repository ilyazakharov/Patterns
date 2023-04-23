namespace Patterns.Mediator;

/// <summary>
/// Mediator interface.
/// </summary>
internal interface IMediator
{
    /// <summary>
    /// Sends a message to the needed colleague.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="colleague">Sender.</param>
    void Send(string message, Colleague colleague);
}
