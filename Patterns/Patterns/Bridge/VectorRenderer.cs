namespace Patterns.Bridge;

/// <summary>
/// Vector renderer.
/// </summary>
internal class VectorRenderer : IRenderer
{
    /// <inheritdoc/>
    public void DrawCircle(float radius)
    {
        Console.WriteLine($"Draw a circle with radius {radius} using formulas.");
    }

    /// <inheritdoc/>
    public void DrawSquare(float sideLength)
    {
        Console.WriteLine($"Draw a sqaure with side length {sideLength} using formulas.");
    }
}
