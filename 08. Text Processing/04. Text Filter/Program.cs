string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();
foreach (var wordToBan in bannedWords)
{
    text = text.Replace(wordToBan, new string('*', wordToBan.Length));
}
Console.WriteLine(text);