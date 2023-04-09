namespace Patterns.Bridge;

/// <summary>
/// Abstract class for shapes.
/// </summary>
internal abstract class Shape
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Shape"/> class.
    /// </summary>
    /// <param name="renderer">Renderer for the shape.</param>
    protected Shape(IRenderer renderer)
    {
        this.Renderer = renderer;
    }

    /// <summary>
    /// Gets or sets the renderer for the shape.
    /// </summary>
    public IRenderer Renderer { get; set; }

    /// <summary>
    /// Draw a shape.
    /// </summary>
    public abstract void Draw();
}
