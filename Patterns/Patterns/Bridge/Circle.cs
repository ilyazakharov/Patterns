namespace Patterns.Bridge;

/// <summary>
/// Circle shape.
/// </summary>
internal class Circle : Shape
{
    private readonly float radius;

    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class.
    /// </summary>
    /// <param name="renderer">The renderer for the shape.</param>
    /// <param name="radius">Radius of the circle.</param>
    public Circle(IRenderer renderer, float radius)
        : base(renderer)
    {
        this.radius = radius;
    }

    /// <inheritdoc/>
    public override void Draw()
    {
        this.Renderer.DrawCircle(this.radius);
    }
}
