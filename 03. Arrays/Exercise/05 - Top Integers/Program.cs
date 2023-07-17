int[] numArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < numArr.Length;  i++)
{
    bool maxElement = true;
    for (int j = i + 1; j < numArr.Length; j++)
	{
		if (numArr[i] <= numArr[j])
		{
			maxElement = false;
			break;
		}
	}
    if (maxElement)
    {
		Console.Write(numArr[i] + " ");
    }
}
