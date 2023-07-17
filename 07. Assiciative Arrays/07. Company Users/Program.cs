var register = new Dictionary<string, List<string>>();
string input;
while ((input = Console.ReadLine())!= "End")
{
    string[] info = input.Split(" -> ");
    string companyName = info[0];
    string iD = info[1];
    if (!register.ContainsKey(companyName))
    {
        register.Add(companyName, new List<string>());
    }
       if(!register[companyName].Contains(iD))
       {
            register[companyName].Add(iD);
       }
}
foreach (var kvp in register)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(string.Join(Environment.NewLine, kvp.Value.Select(x => $"-- {x}")));
}