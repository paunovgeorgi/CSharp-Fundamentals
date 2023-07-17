
using System.Dynamic;

var dwarfs = new Dictionary<string, List<Dwarf>>();
string input;

while ((input = Console.ReadLine()) != "Once upon a time")
{
    string[] details = input.Split(" <:> ");

    string name = details[0];
    string color = details[1];
    int physics = int.Parse(details[2]);

    if (!dwarfs.ContainsKey(color))
    {
        Dwarf dwarf = new Dwarf(name, physics);
        dwarfs.Add(color, new List<Dwarf>());
        dwarfs[color].Add(dwarf);
    }
    else
    {
        bool isMatch = false;
        foreach (var dwarf in dwarfs[color])
        {
            if (dwarf.Name == name)
            {
                isMatch = true;
                if (dwarf.Physic < physics)
                {
                    dwarf.Physic = physics;
                }
            }
        }

        if (!isMatch)
        {
            dwarfs[color].Add(new Dwarf(name, physics));
        }
    }

}
var orderedDwarfs = dwarfs.OrderByDescending(pair => pair.Value.OrderByDescending(dwarf => dwarf.Physic).FirstOrDefault())
    .ThenByDescending(pair => pair.Value.Count);

foreach (var pair in orderedDwarfs)
{
    string color = pair.Key;
    List<Dwarf> dwarfsList = pair.Value;

    if (dwarfsList.Any())
    {
        foreach (var dwarf in dwarfsList)
        {
            Console.WriteLine($"({color}) {dwarf.Name} <-> {dwarf.Physic}");
        }
    }
    else
    {
        Console.WriteLine($"({color}) No dwarfs found.");
    }
}

public class Dwarf
{
    public Dwarf(string name, int physic)
    {
        Name = name;
        Physic = physic;
    }

    public string Name { get; set; }
    public int Physic { get; set; }


}
