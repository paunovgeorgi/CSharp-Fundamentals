string encryptedText = Console.ReadLine();
string input;
while ((input = Console.ReadLine()) != "Decode")
{
    string[] commands = input.Split('|');
    string command = commands[0];
    switch (command)
    {
        case "Move":
            int lettersToMove = int.Parse(commands[1]);
            encryptedText = MoveLetters(encryptedText, lettersToMove);
            break;
        case "Insert":
            int index = int.Parse(commands[1]);
            string value = commands[2];
            encryptedText = encryptedText.Insert(index, value);
            break;
        case "ChangeAll":
            string lettersToRemove = commands[1];
            string replacement = commands[2];
            encryptedText = encryptedText.Replace(lettersToRemove, replacement);
            break;
    }
}
Console.WriteLine($"The decrypted message is: {encryptedText}");
string MoveLetters(string encrypted, int moves)
{
    string sub = encrypted.Substring(0, moves);
    encrypted = encrypted.Remove(0, moves);
    encrypted += sub;
    return encrypted;
}