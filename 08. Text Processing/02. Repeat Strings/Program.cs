//string[] input = Console.ReadLine().Split();
//foreach (var word in input)
//{
//    string output = "";
//    for (int i = 0; i < word.Length; i++)
//    {
//        output += word;
//    }
//    Console.Write(output);
//}

using System.Text;
string[] input = Console.ReadLine().Split();
StringBuilder output = new StringBuilder();
foreach (var s in input)
{
    for (int i = 0; i < s.Length; i++)
    {
        output.Append(s);
    }
}
Console.WriteLine(output);