namespace Lab1App;

/// <summary>
/// Represents triangle object.
/// </summary>
public class Triangle : Figure
{
    private readonly string stringRepresentationOfTriangle;

    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle"/> class.
    /// </summary>
    /// <param name="figureId">Uniq figure id.</param>
    /// <param name="firstPoint">First point of triangle.</param>
    /// <param name="secondPoint">Second point of triangle.</param>
    /// <param name="thirdPoint">Third point of triangle.</param>
    public Triangle(int figureId, Position firstPoint, Position secondPoint, Position thirdPoint)
                : base(figureId, firstPoint, thirdPoint)
    {
        this.stringRepresentationOfTriangle = $"I am {nameof(Triangle)} with this three points: {firstPoint}, {secondPoint}, {thirdPoint}";
    }

    /// <summary>
    /// Draws triangle by returning its string representation.
    /// </summary>
    /// <returns>String representation of triangle.</returns>
    public override string Draw()
    {
        return this.stringRepresentationOfTriangle;
    }
}