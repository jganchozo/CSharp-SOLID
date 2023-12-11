// See https://aka.ms/new-console-template for more information

using Solution;

AreaCalculator areaCalculator = new();

List<IShape> shapes = new()
            {
                new Rectangle { Height = 20, With = 40 },
                new Circle { Radius = 10 }
            };

Console.WriteLine(areaCalculator.Area(shapes));
Console.ReadLine();