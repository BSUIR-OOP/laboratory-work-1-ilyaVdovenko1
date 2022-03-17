namespace Lab1App;

/// <summary>
/// Represents circle object.
/// </summary>
public class Circle : Figure
{
    private readonly string drawCircleRepresentation;

    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class.
    /// </summary>
    /// <param name="figureId">Uniq circle id.</param>
    /// <param name="startPoint">Start point for draw.</param>
    /// <param name="radius">Circle radius.</param>
    public Circle(int figureId, Position startPoint, decimal radius)
        : base(figureId, startPoint, startPoint)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Circle radius can not be less then 0", nameof(radius));
        }

        this.Radius = radius;
        this.drawCircleRepresentation =
            $"I am the {nameof(Circle)} with start point {this.StartPoint} and radius {this.Radius}";
    }

    /// <summary>
    /// Gets circle radius.
    /// </summary>
    /// <value>
    /// Circle radius.
    /// </value>
    public decimal Radius { get; }

    /// <summary>
    /// Provides drawing circle.
    /// </summary>
    /// <returns>String representation of drawing circle.</returns>
    public override string Draw()
    {
        return this.drawCircleRepresentation;
    }
}