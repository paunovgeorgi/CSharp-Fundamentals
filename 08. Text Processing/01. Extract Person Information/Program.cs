int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int nameFirstIndex = input.IndexOf('@') + 1;
    int nameLastIndex = input.IndexOf('|');
    string name = input.Substring(nameFirstIndex, nameLastIndex - nameFirstIndex);
    int ageFirstIndex = input.IndexOf('#') + 1;
    int ageLastIndex = input.IndexOf('*');
    string age = input.Substring(ageFirstIndex, ageLastIndex - ageFirstIndex);
    Console.WriteLine($"{name} is {age} years old.");
}