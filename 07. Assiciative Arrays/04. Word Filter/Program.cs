namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
               //string[] input = Console.ReadLine().Split().Where(x=>x.Length % 2 == 0).ToArray();

               //foreach (var word in input)
               //{
               //    Console.WriteLine(word);
               //}

                Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList().ForEach(Console.WriteLine);
        }

    }
}