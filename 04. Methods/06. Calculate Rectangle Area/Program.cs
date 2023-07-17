double sideA = double.Parse(Console.ReadLine());
double sideB = double.Parse(Console.ReadLine());

double area = RectangleArea(sideA, sideB);
Console.WriteLine(area);

static double RectangleArea(double a, double b)
{
    return a * b;
}