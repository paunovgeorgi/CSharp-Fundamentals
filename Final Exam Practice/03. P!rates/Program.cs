using System.Security.Cryptography;
var cities = new Dictionary<string, CityInfo>();
string initialInput;
while ((initialInput = Console.ReadLine())!="Sail")
{
string[] info = initialInput.Split("||");
string name = info[0];
double population = double.Parse(info[1]);
double gold = double.Parse(info[2]);
if (cities.ContainsKey(name))
{
    cities[name].Population += population;
    cities[name].Gold += gold;
}
else
{
    cities.Add(name, new CityInfo(population, gold));
}
}

string events;
while ((events = Console.ReadLine())!="End")
{
    string[] arguments = events.Split("=>");
    string command = arguments[0];
    switch (command)
    {
        case "Plunder":
            string town = arguments[1];
            int people = int.Parse(arguments[2]);
            double gold = double.Parse(arguments[3]);
            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
            cities[town].Population -= people;
            cities[town].Gold -= gold;
            if (cities[town].Gold <= 0 || cities[town].Population <= 0)
            {
                cities.Remove(town);
                Console.WriteLine($"{town} has been wiped off the map!");
            }
            break;
        case "Prosper":
            town = arguments[1];
            gold = double.Parse(arguments[2]);
            if (gold >= 0)
            {
                cities[town].Gold += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
            }
            else
            {
                Console.WriteLine("Gold added cannot be a negative number!");    
            }
            break;
    }
}

if (cities.Count <= 0)
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}
else
{
    Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
    foreach (var city in cities)
    {
        Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
    }
}
public class CityInfo
{
    public CityInfo(double population, double gold)
    {
        Population = population;
        Gold = gold;
    }

    public double Population { get; set; }
    public double Gold { get; set; }
}