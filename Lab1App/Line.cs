namespace Lab1App;

/// <summary>
/// Represents line.
/// </summary>
public class Line : Figure
{
    private readonly string stringRepresentationOfLine;

    /// <summary>
    /// Initializes a new instance of the <see cref="Line"/> class.
    /// </summary>
    /// <param name="figureId">Uniq figure id.</param>
    /// <param name="startPoint">Start point of line.</param>
    /// <param name="endPoint">End point of line.</param>
    public Line(int figureId, Position startPoint, Position endPoint)
        : base(figureId, startPoint, endPoint)
    {
        this.Length = Math.Round(Math.Sqrt(Math.Pow(startPoint.XCoordinate - endPoint.XCoordinate, 2) +
                                      Math.Pow(startPoint.YCoordinate - endPoint.YCoordinate, 2)));
        this.stringRepresentationOfLine = $"I am the line with length {this.Length}";
        this.FunctionalDependence = this.GetPointByOneCoordinate;
    }

    /// <summary>
    /// Gets functional dependence of new dots from x coordinates.
    /// </summary>
    /// <value>
    /// Functional dependence of new dots from x coordinates.
    /// </value>
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    // ReSharper disable once MemberCanBePrivate.Global
    public Func<int, Position> FunctionalDependence { get; }

    /// <summary>
    /// Gets line length.
    /// </summary>
    /// <value>
    /// Line length.
    /// </value>
    // ReSharper disable once MemberCanBePrivate.Global
    public double Length { get; }

    /// <summary>
    /// Draw line as string representation.
    /// </summary>
    /// <returns>String representation of line.</returns>
    public override string Draw()
    {
        return this.stringRepresentationOfLine;
    }

    /// <summary>
    /// Checks if line contains dot.
    /// </summary>
    /// <param name="dot">Dot to check.</param>
    /// <returns>True if contains, else - false.</returns>
    public bool IfLineContainsDot(Position dot)
    {
        var newDot = this.GetPointByOneCoordinate(dot.XCoordinate);
        return newDot.YCoordinate == dot.YCoordinate;
    }

    private Position GetPointByOneCoordinate(int x)
    {
        var gradientX = this.StartPoint.XCoordinate - this.EndPoint.XCoordinate;
        var gradientY = this.StartPoint.YCoordinate - this.EndPoint.YCoordinate;
        if (gradientX == 0)
        {
            return new Position(x, this.StartPoint.YCoordinate);
        }

        var lineSlope = (double)gradientY / gradientX;
        var y = (int)Math.Round(
            (lineSlope * (x - this.StartPoint.XCoordinate)) + this.StartPoint.YCoordinate,
            MidpointRounding.ToZero);
        return new Position(x, y);
    }
}