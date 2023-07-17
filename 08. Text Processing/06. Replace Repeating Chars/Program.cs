using System.Text;
//string input = Console.ReadLine();
//var sb = new StringBuilder();
//for (int i = 0; i < input.Length; i++)
//{
//    if (i + 1 < input.Length)
//    {
//    if (input[i] != input[i + 1])
//    {
//        sb.Append(input[i]);
//    }
//    }
//}
//sb.Append(input[input.Length - 1]);
//Console.WriteLine(sb);

string input = Console.ReadLine();
for (int i = 0; i < input.Length; i++)
{
    if (i + 1 < input.Length)
    {
    if (input[i] == input[i + 1])
    {
        input = input.Remove(i, 1);
    i = -1;
    }
    }
}
Console.WriteLine(input);