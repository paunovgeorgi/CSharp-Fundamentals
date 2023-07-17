using System.Collections.Generic;
List<string> sequence = Console.ReadLine()
    .Split()
    .ToList();

string command;
int moves = 0;
while ((command = Console.ReadLine()) != "end")
{
    int[] integers = command.Split().Select(int.Parse).ToArray();

    if (sequence.Count == 0)
    {
        Console.WriteLine($"You have won in {moves} turns!");
        break;
    }

    moves++;
    int firstIndex = integers[0];
    int secondIndex = integers[1];
    string moveElement = $"-{moves}a";

    if (ElementsOutOfRange(sequence, firstIndex, secondIndex))
    {
        sequence.Insert(sequence.Count / 2, moveElement);
        sequence.Insert(sequence.Count / 2, moveElement);
        Console.WriteLine("Invalid input! Adding additional elements to the board");
    
    }
    else if (MatchingElements(sequence, firstIndex, secondIndex)) 
    {
        Console.WriteLine($"Congrats! You have found matching elements - {sequence[firstIndex]}!");
        string ElementToRemove = sequence[firstIndex];
        sequence.RemoveAll(x => x == ElementToRemove);
  
    }
    else if (!ElementsOutOfRange(sequence, firstIndex, secondIndex) && !MatchingElements(sequence, firstIndex, secondIndex))
    {
        Console.WriteLine("Try again!");
    }
}

if (command == "end" && sequence.Count > 0)
{
    Console.WriteLine("Sorry you lose :(");
    Console.WriteLine(string.Join(" ", sequence));
}
else if (command == "end" && sequence.Count == 0)
{
    Console.WriteLine($"You have won in {moves} turns!");
}

static bool ElementsOutOfRange(List<string> sequence, int firstIndex, int secondIndex)
{
    return firstIndex == secondIndex || firstIndex < 0 || firstIndex >= sequence.Count || secondIndex < 0 || secondIndex >= sequence.Count;
}

static bool MatchingElements(List<string> sequence, int firstIndex, int secondIndex)
{
    return sequence[firstIndex] == sequence[secondIndex];
}