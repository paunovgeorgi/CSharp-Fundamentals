int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
	char firstChar = (char)('a' + i);
	for (int j = 0; j < number; j++)
	{
        char second = (char)('a' + j);
        for (int k = 0; k < number; k++)
		{
            char third = (char)('a' + k);
			Console.WriteLine($"{firstChar}{second}{third}");
        }
	}
}