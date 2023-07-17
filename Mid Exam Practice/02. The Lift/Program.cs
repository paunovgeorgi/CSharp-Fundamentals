int numOfPeoplWaiting = int.Parse(Console.ReadLine());

int[] wagonCurrentState = Console.ReadLine().Split()
    .Select(int.Parse)
    .ToArray();
int totalSeats = wagonCurrentState.Length * 4;
int takenSeats = 0;

for (int i = 0; i < wagonCurrentState.Length; i++)
{
    takenSeats += wagonCurrentState[i];
}
int freeSeats = totalSeats - takenSeats;
for (int i = 0; i < wagonCurrentState.Length; i++)
{
    for (int j = wagonCurrentState[i]; j < 4; j++)
    {
        wagonCurrentState[i] += 1;
        numOfPeoplWaiting -= 1;
        freeSeats -= 1;
        if (freeSeats == 0 && numOfPeoplWaiting > 0)
        {
            Console.WriteLine($"There isn't enough space! {numOfPeoplWaiting} people in a queue!");
            Console.WriteLine(string.Join(" ", wagonCurrentState));
            break;
        }
        else if (freeSeats == 0 && numOfPeoplWaiting == 0)
        {
            Console.WriteLine(string.Join(" ", wagonCurrentState));
            break;
        }
        else if (freeSeats > 0 && numOfPeoplWaiting == 0)
        {
            Console.WriteLine("The lift has empty spots!");
            Console.WriteLine(string.Join(" ", wagonCurrentState));
            break;

        }
    }
}

