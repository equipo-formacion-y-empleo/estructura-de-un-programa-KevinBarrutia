float totalSurface = 0;

double CalculateRectangleAreas(double width, double height)
{
    double rectangleArea = width * height;
    totalSurface += (float)rectangleArea;
    return rectangleArea;
}

double area1 = CalculateRectangleAreas(double.Parse(args.Length > 0 ? args[0] : "3"), double.Parse(args.Length > 1 ? args[1] : "4"));
double area2 = CalculateRectangleAreas(double.Parse(args.Length > 2 ? args[2] : "5"), double.Parse(args.Length > 3 ? args[3] : "6"));
Console.WriteLine($"Área1: {area1}");
Console.WriteLine($"Área2: {area2}");
Console.WriteLine($"Suma total de superficies: {totalSurface}");