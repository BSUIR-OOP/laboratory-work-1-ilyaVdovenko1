#pragma warning disable SA1200
using Lab1App;
#pragma warning restore SA1200

var listOfFigures = new List<Figure>()
{
    new Dot(0, new Position(0, 0)),
    new Dot(1, new Position(0, 1)),
    new Dot(2, new Position(1, 0)),
    new Dot(3, new Position(1, 1)),
};

foreach (var figure in listOfFigures)
{
    Console.WriteLine(figure.Draw());
}