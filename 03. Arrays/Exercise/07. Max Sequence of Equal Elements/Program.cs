int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int maxSeq = 0;
int currentNUm = 0;

for (int i = 0; i < array.Length - 1; i++)
{
    int counter = 1;
    for (int j = i + 1; j < array.Length; j++)
	{
		if (array[i] == array[j])
		{
			counter++;
		}
		else
		{
			break;
		}
    }
        if (counter > maxSeq)
        {
            maxSeq = counter;
        currentNUm = array[i];
        }      
}
int[] sequence = new int[maxSeq];
for (int k = 0; k < maxSeq; k++)
{
    sequence[k] = currentNUm;
}
Console.Write(string.Join(" ", sequence));