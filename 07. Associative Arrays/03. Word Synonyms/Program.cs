namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(synonym);
            }

            ConsoleWriteMethod(words);
        }

        private static void ConsoleWriteMethod(Dictionary<string, List<string>> words)
        {
            foreach (var word in words)
            {
                Console.Write(word.Key + " - ");
                Console.Write(string.Join(", ", word.Value));
                Console.WriteLine();
            }
        }
    }
}