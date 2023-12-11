// See https://aka.ms/new-console-template for more information

using Problem;

AreaCalculator areaCalculator = new();

List<object> shapes = new()
            {
                new Rectangle { Height = 20, With = 40 },
                new Circle { Radius = 10 }
            };

Console.WriteLine(areaCalculator.Area(shapes));
Console.ReadLine();
