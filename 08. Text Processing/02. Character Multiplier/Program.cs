string[] input = Console.ReadLine().Split();
string word1 = input[0];
string word2 = input[1];
int counter = Math.Max(word1.Length, word2.Length);
Console.WriteLine(GetSum(word1, word2, counter));
static int GetSum(string wordOne, string wordTwo, int counter)
{
    int sum = 0;
    for (int i = 0; i < counter; i++)
    {
        int code1 = i < wordOne.Length ? wordOne[i] : 1;
        int code2 = i < wordTwo.Length ? wordTwo[i] : 1;
        sum += code1 * code2;
    }
    return sum;
}