int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
string command;
while ((command = Console.ReadLine()) != "find")
{
    string currentInput = command;
    string decrypted = string.Empty;
    while (currentInput.Length > 0)
    {
    for (int i = 0; i < numbers.Length; i++)
    {
        if (currentInput.Length > 0)
        {
            char currentChar = (char)(command[i] - numbers[i]);
            decrypted += currentChar;
            currentInput = currentInput.Remove(0, 1);
        }
        else
        {
            break;
        }
    }

    if (currentInput.Length > 0)
    {
    command = command.Remove(0, numbers.Length);
    }
    }

    int typeStart = decrypted.IndexOf('&') + 1;
    int typeEnd = decrypted.LastIndexOf('&');
    string treasureType = decrypted.Substring(typeStart, typeEnd - typeStart);
    int coordinatesStart = decrypted.IndexOf('<') + 1;
    int coordinatesEnd = decrypted.LastIndexOf('>');
    string treasureCoordinates = decrypted.Substring(coordinatesStart, coordinatesEnd - coordinatesStart);
    Console.WriteLine($"Found {treasureType} at {treasureCoordinates}");
}