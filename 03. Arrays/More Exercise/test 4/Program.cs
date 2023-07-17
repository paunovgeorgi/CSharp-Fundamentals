int numOfNames = int.Parse(Console.ReadLine());
double[] finalArray = new double[numOfNames];
for (int j = 0; j < numOfNames; j++)
{
    string name = Console.ReadLine();
    int vowelSum = 0;
    double consonantSum = 0;
    int totalVowelSum = 0;

    for (int i = 0; i < name.Length; i++)
    {
        if (name[i] == 'a' || name[i] == 'e' || name[i] == 'o' || name[i] == 'u' || name[i] == 'i'
            || name[i] == 'A' || name[i] == 'E' || name[i] == 'O' || name[i] == 'U' || name[i] == 'I')
        {
            vowelSum += name[i];
        }
        else
        {
            consonantSum += (int)name[i] / name.Length;
        }
    }
    totalVowelSum = vowelSum * name.Length;
    finalArray[j] = totalVowelSum + consonantSum;
}
Array.Sort(finalArray);

foreach (double element in finalArray)
{
    Console.WriteLine(element);
}