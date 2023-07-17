using System.ComponentModel.Design;
using System.Text.RegularExpressions;
int n = int.Parse(Console.ReadLine());
string pattern = @"[@][#]+([A-Z][A-Za-z0-9]{4,}[A-Z])[@][#]+";
//Regex regex = new Regex(pattern);
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    if (Regex.IsMatch(input, pattern))
    {
        Match currentMatch = Regex.Match(input, pattern);
        string currentBarcode = currentMatch.Groups[1].Value;
        string group = new string(currentBarcode.Where(char.IsDigit).ToArray());
        //string group = string.Empty;
        //foreach (char c in currentBarcode)
        //{
        //    if (c >= '0' && c <= '9')
        //    {
        //        group += c;
        //    }
        //}
        if (group != "")
        {
            Console.WriteLine($"Product group: {group}");
        }
        else
        {
            Console.WriteLine("Product group: 00");
        }
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
}