namespace Patterns.Mediator;

/// <summary>
/// Pupil.
/// </summary>
internal class Pupil : Colleague
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Pupil"/> class.
    /// </summary>
    /// <param name="mediator">Mediator.</param>
    public Pupil(IMediator mediator)
        : base(mediator)
    {
    }

    /// <inheritdoc/>
    public override void Notify(string message)
    {
        Console.WriteLine($"Pupil received a message: {message}");
    }
}
