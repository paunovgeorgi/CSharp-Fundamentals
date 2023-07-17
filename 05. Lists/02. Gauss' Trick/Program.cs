List<int> sequence = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();

for (int i = 0; i < sequence.Count /2 ; i++)
{
int sum = 0;
   sum += sequence[i] + sequence[sequence.Count - 1 - i];
   result.Add(sum);
}

if (sequence.Count % 2 != 0)
{
    result.Add(sequence[sequence.Count / 2]);
}
Console.WriteLine(string.Join(" ", result));