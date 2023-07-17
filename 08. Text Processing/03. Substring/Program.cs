string wordToRemove = Console.ReadLine();
string text = Console.ReadLine();
while (text.Contains(wordToRemove))
{
int firstIndex = text.IndexOf(wordToRemove);
text = text.Remove(firstIndex, wordToRemove.Length);
}
Console.WriteLine(text);