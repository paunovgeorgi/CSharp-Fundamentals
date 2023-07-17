int startingYield = int.Parse(Console.ReadLine());
int totalYield = 0;
int days = 0;
while (startingYield >= 100)
{
    days++;
    totalYield += startingYield - 26;
    startingYield -= 10;
}
Console.WriteLine(days);
if (days == 0)
{
    Console.WriteLine(totalYield);
}
else
{
    Console.WriteLine(totalYield - 26);
}