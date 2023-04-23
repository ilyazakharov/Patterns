namespace Patterns.Mediator;

/// <summary>
/// Abstract colleague.
/// </summary>
internal abstract class Colleague
{
    /// <summary>
    /// Mediator.
    /// </summary>
    protected IMediator mediator;

    /// <summary>
    /// Initializes a new instance of the <see cref="Colleague"/> class.
    /// </summary>
    /// <param name="mediator">Mediator.</param>
    public Colleague(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Send a message.
    /// </summary>
    /// <param name="message">Message.</param>
    public void Send(string message)
    {
        this.mediator.Send(message, this);
    }

    /// <summary>
    /// Notify.
    /// </summary>
    /// <param name="message">Message.</param>
    public abstract void Notify(string message);
}
