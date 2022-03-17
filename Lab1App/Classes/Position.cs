namespace Lab1App.Classes;

/// <summary>
/// Represents position of object on the 2-D screen.
/// </summary>
public class Position : object
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Position"/> class.
    /// </summary>
    /// <param name="x">X-position on the screen.</param>
    /// <param name="y">Y-position on the screen.</param>
    public Position(int x, int y)
    {
        if (x < 0)
        {
            throw new ArgumentException("Coordinate can not be less then 0", nameof(x));
        }

        if (y < 0)
        {
            throw new ArgumentException("Coordinate can not be less then 0", nameof(y));
        }

        this.XCoordinate = x;
        this.YCoordinate = y;
    }

    /// <summary>
    /// Gets X-coordinate of object position.
    /// </summary>
    /// <value>
    /// X-coordinate of object position.
    /// </value>
    public int XCoordinate { get; }

    /// <summary>
    /// Gets Y-coordinate of object position.
    /// </summary>
    /// <value>
    /// Y-coordinate of object position.
    /// </value>
    public int YCoordinate { get; }

    /// <summary>
    /// Compares current position with other.
    /// </summary>
    /// <param name="other">Other position.</param>
    /// <returns>True if positions are equals, false - if not.</returns>
    public bool Equals(Position? other)
    {
        return other is not null
               && ReferenceEquals(this, other)
               && this.XCoordinate == other.XCoordinate
               && this.YCoordinate == other.YCoordinate;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"({this.XCoordinate}, {this.YCoordinate})";
    }
}