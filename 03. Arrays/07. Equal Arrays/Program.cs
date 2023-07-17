using System;

int[] numberSequence1 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] numberSequence2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;
bool areIdentical = true;

for (int i = 0; i < numberSequence1.Length; i++)
{
    if (numberSequence1[i] == numberSequence2[i])
    {
        sum += numberSequence1[i];
    }
    else
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        areIdentical = false;
        break;
    }
}
if (areIdentical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}



