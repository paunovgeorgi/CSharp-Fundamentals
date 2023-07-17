namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string caseInsensitive = word.ToLower();
                if (!count.ContainsKey(caseInsensitive))
                {
                    count.Add(caseInsensitive, 0);
                }
                count[caseInsensitive]++;
            }

           /* foreach (var item in count.Where(x=>x.Value % 2 != 0))
            {
                Console.Write(item.Key + " ");
            }*/

           var result = count.Where(x => x.Value % 2 != 0)
               .Select(x => x.Key).ToList();

           Console.WriteLine(string.Join(" ", result));
        }
    }
}