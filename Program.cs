using Dotnet_OOPS.Task1;
using Dotnet_OOPS.Task2;
using Dotnet_OOPS.Task3;

Circle circle = new Circle();
circle.Draw();
circle.Draw(4);

Shape rectangle = new Rectangle();
rectangle.Draw();
Rectangle.Fun();
Shape.Fun();

Console.WriteLine("-----------------");

IShape square = new Square2();
Console.WriteLine("Area of square: " + square.CalculateArea(4));
Console.WriteLine("Perimeter of square: " + square.CalculatePerimeter(4));

IShape circle2 = new Circle2();
Console.WriteLine("Area of circle: " + circle2.CalculateArea(4));
Console.WriteLine("Perimeter of circle: " + circle2.CalculatePerimeter(4));

Console.WriteLine("-----------------");

Employee dev = new Developer();
dev.CalculateSalary();

Employee mgr = new Manager();
mgr.CalculateSalary();