int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());
int targets = 0;
int originalPowerValue = power;

while (power >= distance)
{
    power -= distance;
    targets++;
    if (exhaustionFactor > 0)
    {
        if ((double)power == originalPowerValue * 0.5)
        {
            if (power / exhaustionFactor > 0)
            {
                power /= exhaustionFactor;
            }

        }
    }
}
Console.WriteLine(power);
Console.WriteLine(targets);
