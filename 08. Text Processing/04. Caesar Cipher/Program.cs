using System.Text;
string input = Console.ReadLine();

StringBuilder output = new StringBuilder();
foreach (char c in input)
{
    output.Append((char)(c+3));
}
Console.WriteLine(output);

//string strOutput = "";
//for (int i = 0; i < input.Length; i++)
//{
//    char c = (char)(input[i] + 3);
//    strOutput += c;
//}
//Console.WriteLine(strOutput);