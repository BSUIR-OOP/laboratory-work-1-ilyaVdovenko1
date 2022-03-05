namespace Lab1App;

/// <summary>
/// Represents position of object on the 2-D screen.
/// </summary>
public class Position
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Position"/> class.
    /// </summary>
    /// <param name="xCoordinate">X-position on the screen.</param>
    /// <param name="yCoordinate">Y-position on the screen.</param>
    public Position(int xCoordinate, int yCoordinate)
    {
        this.XCoordinate = xCoordinate;
        this.YCoordinate = yCoordinate;
    }

    /// <summary>
    /// Gets X-coordinate of object position.
    /// </summary>
    public int XCoordinate { get; }

    /// <summary>
    /// Gets Y-coordinate of object position.
    /// </summary>
    public int YCoordinate { get; }
}