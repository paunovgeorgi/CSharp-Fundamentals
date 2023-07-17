int numberOfWagons = int.Parse(Console.ReadLine());
int[] peoplePerWagon = new int[numberOfWagons];

for (int i = 0; i < peoplePerWagon.Length; i++)
{
    int numOfPeople = int.Parse(Console.ReadLine());
    peoplePerWagon[i] = numOfPeople;
}

Console.WriteLine(String.Join(" ", peoplePerWagon));
Console.WriteLine(peoplePerWagon.Sum());