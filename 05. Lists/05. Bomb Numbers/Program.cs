List<int> numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToList();

int[] bombNum = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int bombNumber = bombNum[0];
int power = bombNum[1];
List<int> bombIndex = new List<int>();

numbers = RemoveBombNumbers(numbers, bombNumber, bombIndex, power);

Console.WriteLine(SumRemainingNumbers(numbers));


static List<int> RemoveBombNumbers(List<int> numberString, int bombNumber, List<int> bombIndex, int power)
{
    while (numberString.Contains(bombNumber))
    {
        int index = numberString.IndexOf(bombNumber);
        int leftIndex = Math.Max(0, index - power);
        int rightIndex = Math.Min(numberString.Count - 1, index + power);
        int rangeLength = rightIndex - leftIndex + 1;

        numberString.RemoveRange(leftIndex, rangeLength);
    }
    return numberString;
}

static int SumRemainingNumbers(List<int> numberString)
{
    int remainingSum = 0;
    foreach (int number in numberString)
    {
        remainingSum += number;
    }

    return remainingSum;
}