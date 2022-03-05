// ReSharper disable All
namespace Lab1App;

/// <summary>
/// Represents dot figure.
/// </summary>
public class Dot : Figure
{
    private readonly string stringDrawDotRepresentation;

    /// <summary>
    /// Initializes a new instance of the <see cref="Dot"/> class.
    /// </summary>
    /// <param name="figureId">Uniq figure id.</param>
    /// <param name="point">Represents figure screen start point.</param>
    public Dot(int figureId, Position point)
        : base(figureId, point, point)
    {
        this.stringDrawDotRepresentation = "I am a dot with " +
                                      $"({this.StartPoint.XCoordinate}, {this.StartPoint.YCoordinate}) point position";
    }

    /// <summary>
    /// Implements drawing dot logic.
    /// </summary>
    /// <returns>Text represented drawing process.</returns>
    public override string Draw()
    {
        return this.stringDrawDotRepresentation;
    }
}