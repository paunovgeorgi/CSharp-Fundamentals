string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string one = input[0];
string alphabetLowCase = "abcdefghijklmnopqrstuvwxyz";
string alphabetUpperCase =  alphabetLowCase.ToUpper();
double sum = 0;
foreach (var word in input)
{
    char firstChar = word[0];
    char lastChar = word[word.Length - 1];
    string numbers = word.Substring(1, word.Length - 2);
   // string numbers = word[1.. ^1];
    double num = double.Parse(numbers);
    if (char.IsUpper(firstChar))
    {
        int index = alphabetUpperCase.IndexOf(firstChar) + 1;
        num /= index;
    }
    else
    {
        int index = alphabetLowCase.IndexOf(firstChar) + 1;
        num *= index;
    }
    if (char.IsUpper(lastChar))
    {
        int index = alphabetUpperCase.IndexOf(lastChar) + 1;
        num -= index;
    }
    else
    {
        int index = alphabetLowCase.IndexOf(lastChar) + 1;
        num += index;
    }
    sum += num;
}
Console.WriteLine($"{sum:f2}");