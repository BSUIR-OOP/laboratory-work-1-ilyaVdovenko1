namespace Lab1App;

/// <summary>
/// Class represents all figures in abstract way.
/// </summary>
public abstract class Figure
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Figure"/> class.
    /// </summary>
    /// <param name="figureId">Uniq figure id.</param>
    /// <param name="startPoint">Start position on the screen.</param>
    /// <param name="endPoint">End position on the screen.</param>
    protected Figure(int figureId, Position startPoint, Position endPoint)
    {
        this.StartPoint = startPoint;
        this.EndPoint = endPoint;
        this.FigureId = figureId;
    }

    /// <summary>
    /// Gets figure screen start point.
    /// </summary>
    /// <value>
    /// Figure screen start point.
    /// </value>
    public Position StartPoint { get; }

    /// <summary>
    /// Gets figure screen end point.
    /// </summary>
    /// <value>
    /// Figure screen end point.
    /// </value>
    public Position EndPoint { get; }

    /// <summary>
    /// Gets an uniq figure id.
    /// </summary>
    /// <value>
    /// An uniq figure id.
    /// </value>
    public int FigureId { get; }

    /// <summary>
    /// Implements figure draw logic.
    /// </summary>
    /// <returns>String representation of draw.</returns>
    public abstract string Draw();
}