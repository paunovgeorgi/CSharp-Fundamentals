string message = Console.ReadLine();
string input;
while ((input = Console.ReadLine())!="Reveal")
{
    string[] arguments = input.Split(":|:");
    string command = arguments[0];
    switch (command)
    {
        case "InsertSpace":
            int index = int.Parse(arguments[1]);
            message = message.Insert(index, " ");
            Console.WriteLine(message);
            break;
        case "Reverse":
            string sub = arguments[1];
            if (message.Contains(sub))
            {
                int subIndex = message.IndexOf(sub);
                message = message.Remove(subIndex, sub.Length);
                sub = string.Concat(sub.Reverse());
                message = message.Insert(message.Length, sub);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("error");
            }
            break;
        case "ChangeAll":
            string substring = arguments[1];
            string replacement = arguments[2];
            message = message.Replace(substring, replacement);
            Console.WriteLine(message);
            break;
    }
}
Console.WriteLine($"You have a new text message: {message}");