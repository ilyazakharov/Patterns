namespace Patterns.Bridge;

internal class RasterRenderer : IRenderer
{
    /// <inheritdoc/>
    public void DrawCircle(float radius)
    {
        Console.WriteLine($"Draw a circle with radius {radius} using pixels.");
    }

    /// <inheritdoc/>
    public void DrawSquare(float sideLength)
    {
        Console.WriteLine($"Draw a sqaure with side length {sideLength} using pixels.");
    }
}
