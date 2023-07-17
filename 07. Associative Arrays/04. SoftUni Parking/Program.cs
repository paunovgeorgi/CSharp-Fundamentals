int numOfPlates = int.Parse(Console.ReadLine());
var register = new Dictionary<string, string>();

for (int i = 0; i < numOfPlates; i++)
{
    string[] input = Console.ReadLine().Split();
    string command = input[0];
    string username = input[1];

    switch (command)
    {
        case "register":
    string plateNumber = input[2];
            Register(register, username, plateNumber);
            break;
        default:
            Unregister(register, username);
            break;
    }

}

foreach (var user in register)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}

void Register(Dictionary<string, string> dictionary, string s, string plateNumber1)
{
    if (!dictionary.ContainsKey(s))
    {
        dictionary.Add(s, plateNumber1);
        Console.WriteLine($"{s} registered {plateNumber1} successfully");
    }
    else
    {
        Console.WriteLine($"ERROR: already registered with plate number {plateNumber1}");
    }
}
void Unregister(Dictionary<string, string> ints, string username1)
{
    if (!ints.ContainsKey(username1))
    {
        Console.WriteLine($"ERROR: user {username1} not found");
    }
    else
    {
        ints.Remove(username1);
        Console.WriteLine($"{username1} unregistered successfully");
    }
}
