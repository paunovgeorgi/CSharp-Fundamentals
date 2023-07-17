using System.Text;
string input = Console.ReadLine();
int strength = 0;
var sb = new StringBuilder();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        strength += int.Parse(input[i + 1].ToString());
        sb.Append(input[i]);
    }
    else if (strength == 0)
    {
        sb.Append(input[i]);
    }
    else
    {
        strength--;
    }
}
Console.WriteLine(sb);