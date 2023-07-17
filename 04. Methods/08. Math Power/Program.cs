double theBase = double.Parse(Console.ReadLine());
double thePower = double.Parse(Console.ReadLine());

double Power = PowerMethod(theBase, thePower);
Console.WriteLine(Power);

static double PowerMethod(double baase, double power)
{
    double result = Math.Pow(baase, power);
    return result;
}