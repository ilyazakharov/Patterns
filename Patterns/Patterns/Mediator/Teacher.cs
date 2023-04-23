namespace Patterns.Mediator;

/// <summary>
/// Pupil.
/// </summary>
internal class Teacher : Colleague
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Teacher"/> class.
    /// </summary>
    /// <param name="mediator">Mediator.</param>
    public Teacher(IMediator mediator)
        : base(mediator)
    {
    }

    /// <inheritdoc/>
    public override void Notify(string message)
    {
        Console.WriteLine($"Teacher received a message: {message}");
    }
}
