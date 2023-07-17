
List<int> playerOneHand = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> playerTwoHand = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

while (playerOneHand.Count > 0 && playerTwoHand.Count > 0)
{
    for (int i = 0; i < Math.Min(playerOneHand.Count, playerTwoHand.Count); i++)
    {
    if (playerOneHand[i] == playerTwoHand[i])
    {
        playerOneHand.RemoveAt(i);
        playerTwoHand.RemoveAt(i);
    }
    else if (playerOneHand[i] > playerTwoHand[i])
    {
        playerOneHand.Add(playerTwoHand[i]);
        playerOneHand.Add(playerOneHand[i]);
            playerTwoHand.RemoveAt(i);
            playerOneHand.RemoveAt(i);
    }
    else
    {
        playerTwoHand.Add(playerOneHand[i]);
        playerTwoHand.Add(playerTwoHand[i]);
        playerOneHand.RemoveAt(i);
        playerTwoHand.RemoveAt(i);
        }
    }
}

if (playerOneHand.Count > 0)
{
    Console.WriteLine($"First player wins! Sum: {Sum(playerOneHand)}");
}
else
{
    Console.WriteLine($"Second player wins! Sum: {Sum(playerTwoHand)}");
}
int Sum(List<int> list)
{
    int sum = 0;
    foreach (int num in list)
    {
        sum += num;
    }

    return sum;
}