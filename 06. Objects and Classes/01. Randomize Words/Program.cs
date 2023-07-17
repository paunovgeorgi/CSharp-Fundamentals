Random randm = new Random();
string[] input = Console.ReadLine().Split();


for (int i = 0; i < input.Length; i++)
{
    int pos2 = randm.Next(input.Length);
    Console.Write(input[pos2] + " ");
}