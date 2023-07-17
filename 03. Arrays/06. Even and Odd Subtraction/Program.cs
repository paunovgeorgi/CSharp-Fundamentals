int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sum = 0;
int oddSum = 0;

foreach (var currentNum in numbers)
{
    if (currentNum % 2 == 0)
    {
        sum += currentNum;
    }
    else
    {
        oddSum += currentNum;
    }
}

Console.WriteLine(sum - oddSum);