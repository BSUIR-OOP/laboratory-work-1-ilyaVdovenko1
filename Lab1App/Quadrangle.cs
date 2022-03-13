﻿namespace Lab1App;

/// <summary>
/// Represents Quadrangle.
/// </summary>
public class Quadrangle : Figure
{
    private readonly string stringRepresentationOfQuadrangle;

    /// <summary>
    /// Initializes a new instance of the <see cref="Quadrangle"/> class.
    /// </summary>
    /// <param name="figureId">Uniq figure id.</param>
    /// <param name="firstPoint">First point of Quadrangle.</param>
    /// <param name="secondPoint">Second point of Quadrangle.</param>
    /// <param name="thirdPoint">Third point of Quadrangle.</param>
    /// <param name="fourthPoint">Fourth point of Quadrangle.</param>
    public Quadrangle(int figureId, Position firstPoint, Position secondPoint, Position thirdPoint, Position fourthPoint)
        : base(figureId, firstPoint, thirdPoint)
    {
        this.stringRepresentationOfQuadrangle =
            $"I am the {nameof(Quadrangle)} with this four points: {firstPoint}, {secondPoint}, {thirdPoint}, {fourthPoint}";
    }

    /// <summary>
    /// Draws Quadrangle by returning string representation of it.
    /// </summary>
    /// <returns>String representation of Quadrangle.</returns>
    public override string Draw()
    {
        return this.stringRepresentationOfQuadrangle;
    }
}