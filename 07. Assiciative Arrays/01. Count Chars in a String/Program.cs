namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ", "");
            Dictionary<char, int> output = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (!output.ContainsKey(letter))
                {
                    output.Add(letter, 0);
                }
                output[letter]++;
            }
            foreach (var letter in output)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value} ");
            }
        }
    }
}