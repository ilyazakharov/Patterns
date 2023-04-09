namespace Patterns.Bridge;

/// <summary>
/// Renderer.
/// </summary>
internal interface IRenderer
{
    /// <summary>
    /// Draws a circle.
    /// </summary>
    /// <param name="radius">Radius of the circle.</param>
    void DrawCircle(float radius);

    /// <summary>
    /// Draws a square.
    /// </summary>
    /// <param name="sideLength">The length of on side of the square.</param>
    void DrawSquare(float sideLength);
}
