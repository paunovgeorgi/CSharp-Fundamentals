List<int> listOne = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> listTwo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();
int iterations = Math.Max(listOne.Count, listTwo.Count);

for (int i = 0; i < iterations; i++)
{
    if (listOne.Count > i)
    {
        result.Add(listOne[i]);
    }

    if (listTwo.Count > i)
    {
        result.Add(listTwo[i]);
    }
}

Console.WriteLine(string.Join(" ",  result));