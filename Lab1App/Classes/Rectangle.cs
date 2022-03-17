namespace Lab1App.Classes;

/// <summary>
/// Represents Rectangle.
/// </summary>
public class Rectangle : Quadrangle
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle"/> class.
    /// </summary>
    /// <param name="figureId">Uniq figure id.</param>
    /// <param name="firstPoint">First rectangle point.</param>
    /// <param name="lastPoint">Last rectangle point.</param>
    public Rectangle(int figureId, Position firstPoint, Position lastPoint)
        : base(figureId, firstPoint, lastPoint, typeof(Rectangle))
    {
    }
}