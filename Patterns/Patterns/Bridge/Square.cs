namespace Patterns.Bridge;

/// <summary>
/// Square shape.
/// </summary>
internal class Square : Shape
{
    private readonly float sideLength;

    /// <summary>
    /// Initializes a new instance of the <see cref="Square"/> class.
    /// </summary>
    /// <param name="renderer">The renderer for the shape.</param>
    /// <param name="sideLength">Side length of the square.</param>
    public Square(IRenderer renderer, float sideLength)
        : base(renderer)
    {
        this.sideLength = sideLength;
    }

    /// <inheritdoc/>
    public override void Draw()
    {
        this.Renderer.DrawSquare(this.sideLength);
    }
}
