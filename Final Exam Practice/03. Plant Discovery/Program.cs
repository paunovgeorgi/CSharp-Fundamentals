int n = int.Parse(Console.ReadLine());
var plants = new Dictionary<string, Stats>();
for (int i = 0; i < n; i++)
{
    string[] initialInput = Console.ReadLine().Split("<->");
    AddPlant(initialInput, plants);
}
string additionalInput;
char[] separator = { ' ', '-' };
while ((additionalInput = Console.ReadLine())!= "Exhibition")
{
    string[] arguments = additionalInput.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];
    switch (command)
    {
        case "Rate:":
            string name;
            RatePlant(arguments, plants);
            break;
        case "Update:":
            UpdatePlant(arguments, plants);
            break;
        case "Reset:":
            ResetPlant(arguments, plants);
            break;
    }
}
Console.WriteLine("Plants for the exhibition:");
foreach (var plant in plants)
{
    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.AverageRating:f2}");
}

void RatePlant(string[] arguments, Dictionary<string, Stats> plant)
{
    string name = arguments[1];
    double rating = double.Parse(arguments[2]);
    if (plant.ContainsKey(name))
    {
        plant[name].Rating += rating;
        plant[name].Count++;
    }
    else
    {
        Console.WriteLine("error");
    }
}

void UpdatePlant(string[] strings, Dictionary<string, Stats> plant)
{
    string s;
    s = strings[1];
    double rarity = double.Parse(strings[2]);
    if (plant.ContainsKey(s))
    {
        plant[s].Rarity = rarity;
    }
    else
    {
        Console.WriteLine("error");
    }
}

void ResetPlant(string[] arguments1, Dictionary<string, Stats> plant)
{
    string name1;
    name1 = arguments1[1];
    if (plant.ContainsKey(name1))
    {
        plant[name1].Rating = 0;
        plant[name1].Count = 0;
    }
    else
    {
        Console.WriteLine("error");
    }
}

void AddPlant(string[] initialInput1, Dictionary<string, Stats> plant)
{
    string name = initialInput1[0];
    double rarity = double.Parse(initialInput1[1]);
    if (!plant.ContainsKey(name))
    {
        plant.Add(name, new Stats(rarity));
    }
    else
    {
        plant[name].Rarity = rarity;
    }
}

public class Stats
{
    public Stats(double rarity)
    {
        Rarity = rarity;
    }
    public double Rarity { get; set; }
    public double Rating { get; set; }
    public int Count { get; set; }

    public double AverageRating
    {
        get
        {
            if (Rating > 0)
            {
                return Rating / Count;
            }
            else
            {
                return Rating;
            }
        }
    }
}