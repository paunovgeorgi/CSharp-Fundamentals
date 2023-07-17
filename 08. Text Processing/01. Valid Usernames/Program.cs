string[] input = Console.ReadLine().Split(", ");
foreach (var word in input)
{
if (word.Length >= 3 && word.Length <= 16)
	{
        if (word.All(x=> char.IsLetterOrDigit(x) || x == '-' || x == '_'))
        {
            Console.WriteLine(word);
        }
    }
}