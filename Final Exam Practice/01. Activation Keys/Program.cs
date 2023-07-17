using System;
string activationKey = Console.ReadLine();
string input;
while ((input = Console.ReadLine())!="Generate")
{
    string[] arguments = input.Split(">>>");
    string command = arguments[0];
    switch (command)
    {
        case "Contains":
            string substring = arguments[1];
            if (activationKey.Contains(substring))
            {
                Console.WriteLine($"{activationKey} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
            break;
        case "Flip":
            string upperOrLower = arguments[1];
            int startIndex = int.Parse(arguments[2]);
            int endIndex = int.Parse(arguments[3]);
            string sub = activationKey.Substring(startIndex, endIndex - startIndex);
            if (upperOrLower == "Upper")
            {
                activationKey = activationKey.Replace(sub, sub.ToUpper());
                Console.WriteLine(activationKey);
            }
            else
            {
                activationKey = activationKey.Replace(sub, sub.ToLower());
                Console.WriteLine(activationKey);
            }
            break;
        case "Slice":
            startIndex = int.Parse(arguments[1]);
            endIndex = int.Parse(arguments[2]);
            activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(activationKey);
            break;
    }
}
Console.WriteLine($"Your activation key is: {activationKey}");