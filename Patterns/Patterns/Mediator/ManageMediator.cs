namespace Patterns.Mediator;

/// <summary>
/// Concrete mediator for the school.
/// </summary>
internal class ManageMediator : IMediator
{
    /// <summary>
    /// Gets or sets the pupil.
    /// </summary>
    public Colleague? Pupil { get; set; }

    /// <summary>
    /// Gets or sets the teacher.
    /// </summary>
    public Colleague? Teacher { get; set; }

    /// <summary>
    /// Gets or sets the parent.
    /// </summary>
    public Colleague? Parent { get; set; }

    /// <inheritdoc/>
    public void Send(string message, Colleague colleague)
    {
        if (colleague == this.Pupil)
        {
            this.Teacher?.Notify(message);
        }
        else if (colleague == this.Teacher)
        {
            this.Parent?.Notify(message);
        }
        else if (colleague == this.Parent)
        {
            this.Pupil?.Notify(message);
        }
    }
}
