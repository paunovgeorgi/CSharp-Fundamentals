/*string[] sequence = Console.ReadLine().Split();

for (int i = 0; i < sequence.Length / 2; i++)
{
    string firstElement = sequence[i];
    string lastElement = sequence[sequence.Length - 1 - i];

    sequence[i] = lastElement;
    sequence[sequence.Length - 1 - i] = firstElement;
}

Console.WriteLine(string.Join(" ", sequence)); */

string[] sequence = Console.ReadLine().Split();

Console.WriteLine(String.Join(" ", sequence[^1]));

for (int i = sequence.Length - 1; i >= 0; i--)
{
    Console.Write(sequence[i] + " ");
}