int num = int.Parse(Console.ReadLine());
int[] numberArray = new int[num];

for (int i = 0; i < num; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    numberArray[i] = currentNum;
}

for (int i = numberArray.Length - 1; i >= 0; i--)
{
    Console.Write($"{numberArray[i]} ");
}