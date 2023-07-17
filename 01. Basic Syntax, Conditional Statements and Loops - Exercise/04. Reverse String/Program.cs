namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string final = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                final += input[i];
            }
            Console.WriteLine(final);
        }
    }
}