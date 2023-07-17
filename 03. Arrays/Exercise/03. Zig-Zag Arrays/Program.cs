int numOfArrays = int.Parse(Console.ReadLine());
int[] topArray = new int[numOfArrays];
int[] bottomArray = new int[numOfArrays];

for (int i = 0; i < numOfArrays; i++)
{
    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if(i % 2 == 0)

        {
        topArray[i] = array[0];
        bottomArray[i] = array[1];
    }
    else
    {
        topArray[i] = array[1];
        bottomArray[i] = array[0];
    }
}
Console.WriteLine(String.Join(" ", topArray));
Console.WriteLine(String.Join(" ", bottomArray));
