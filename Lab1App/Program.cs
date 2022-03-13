#pragma warning disable SA1200
using Lab1App;
#pragma warning restore SA1200

var listOfFigures = new List<Figure>()
{
    new Dot(0, new Position(0, 0)),
    new Circle(1, new Position(0, 1), 1),
    new Triangle(2, new Position(1, 0), new Position(3, 4), new Position(5, 6)),
    new Line(3, new Position(1, 1), new Position(3, 7)),
    new Quadrangle(4, new Position(1, 5), new Position(5, 7), new Position(7, 9), new Position(9, 11)),
    new Rectangle(5, new Position(0, 1), new Position(3, 4)),
};

foreach (var figure in listOfFigures)
{
    Console.WriteLine(figure.Draw());
}