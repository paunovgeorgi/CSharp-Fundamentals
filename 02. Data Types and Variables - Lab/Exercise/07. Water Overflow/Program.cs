int n = int.Parse(Console.ReadLine());
int totalSum = 0;
int capacity = 255;
for (int i = 0; i < n; i++)
{
    int liters = int.Parse(Console.ReadLine());
    if (liters > capacity)
    {
        Console.WriteLine("Insufficient capacity!");
        continue;
    }
    totalSum += liters;
    capacity -= liters;
}
Console.WriteLine(totalSum);
