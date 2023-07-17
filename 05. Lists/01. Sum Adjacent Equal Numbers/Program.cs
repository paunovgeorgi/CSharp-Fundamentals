List<double> numSequence = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToList();

for (int i = 0; i < numSequence.Count - 1; i++)
{
    if (numSequence[i] == numSequence[i + 1])
    {
        numSequence[i] += numSequence[i + 1];
        numSequence.RemoveAt(i + 1);
        i = -1;
    }
}
Console.WriteLine(string.Join(" ", numSequence));