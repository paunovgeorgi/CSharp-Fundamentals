string initialInput;
var cities = new Dictionary<string, CityStats>();
while ((initialInput = Console.ReadLine())!= "Sail")
{
    string[] inputData = initialInput.Split("||");
    string city = inputData[0];
    int population = int.Parse(inputData[1]);
    int gold = int.Parse(inputData[2]);
    if (cities.ContainsKey(city))
    {
        cities[city].Population += population;
        cities[city].Gold += gold;
    }
    else
    {
        cities.Add(city, new CityStats(population, gold));
    }
}
string secondaryInput;
while ((secondaryInput = Console.ReadLine()) != "End")
{
    string[] arguments = secondaryInput.Split("=>");
    string command = arguments[0];
    switch (command)
    {
        case "Plunder":
            string town = arguments[1];
            int people = int.Parse(arguments[2]);
            int gold = int.Parse(arguments[3]);
            cities[town].Population -= people;
            cities[town].Gold -= gold;
            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
            if (cities[town].Population <= 0 || cities[town].Gold <= 0)
            {
                Console.WriteLine($"{town} has been wiped off the map!");
                cities.Remove(town);
            }
            break;
        case "Prosper":
            town = arguments[1];
            gold = int.Parse(arguments[2]);
            if (gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
                continue;
            }
            cities[town].Gold += gold;
            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
            break;
    }
}
if (cities.Count == 0)
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}
else
{
    Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
    foreach (var town in cities)
    {
        Console.WriteLine($"{town.Key} -> Population: {town.Value.Population} citizens, Gold: {town.Value.Gold} kg");
    }
}
public class CityStats
{
    public CityStats(int population, int gold)
    {
        Population = population;
        Gold = gold;
    }

    public int Population { get; set; }
    public int Gold { get; set; }
}
