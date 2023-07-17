int n = int.Parse(Console.ReadLine());
Dictionary<string, Info> cars = new Dictionary<string, Info>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split('|');
    string name = input[0];
    double mileage = double.Parse(input[1]);
    double fuel = double.Parse(input[2]);
    cars.Add(name, new Info(mileage, fuel));
}
string commands;
while ((commands= Console.ReadLine())!= "Stop")
{
    string[] arguments = commands.Split(" : ");
    string command = arguments[0];
    switch (command)
    {
        case "Drive":
            string car = arguments[1];
            double distance = double.Parse(arguments[2]);
            double fuel = double.Parse(arguments[3]);
            if (cars[car].Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                cars[car].Fuel -= fuel;
                cars[car].Mileage += distance;
                Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                if (cars[car].Mileage >= 100_000)
                {
                    cars.Remove(car);
                    Console.WriteLine($"Time to sell the {car}!");
                }
            }
            break;
        case "Refuel":
            car = arguments[1];
            fuel = double.Parse(arguments[2]);
            if (cars[car].Fuel + fuel > 75)
            {
                fuel = 75 - cars[car].Fuel;
            }
            cars[car].Fuel += fuel;
            Console.WriteLine($"{car} refueled with {fuel} liters");
            break;
        case "Revert":
            car = arguments[1];
            double km = double.Parse(arguments[2]);
            cars[car].Mileage -= km;
            Console.WriteLine($"{car} mileage decreased by {km} kilometers");
            if (cars[car].Mileage < 10_000)
            {
                cars[car].Mileage = 10_000;
            }
            break;
    }
}

foreach (var car in cars)
{
    Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
}

public class Info
{
    public Info(double mileage, double fuel)
    {
        Mileage = mileage;
        Fuel = fuel;
    }
    public double Mileage { get; set; }
    public double Fuel { get; set; }
}