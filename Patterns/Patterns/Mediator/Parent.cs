namespace Patterns.Mediator;

/// <summary>
/// Pupil.
/// </summary>
internal class Parent : Colleague
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Parent"/> class.
    /// </summary>
    /// <param name="mediator">Mediator.</param>
    public Parent(IMediator mediator)
        : base(mediator)
    {
    }

    /// <inheritdoc/>
    public override void Notify(string message)
    {
        Console.WriteLine($"Parent received a message: {message}");
    }
}
