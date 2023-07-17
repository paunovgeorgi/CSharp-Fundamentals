

Catalog catalog = new Catalog();

string input;
while ((input = Console.ReadLine())!= "end")
{
    string[] info = input.Split('/');
        string brand = info[1];
        string model = info[2];
        string weightOrPower = info[3];

    if (info[0] == "Car")
    {
        Car currentCar = new Car()
        {
            Brand = brand,
            Model = model,
            HorsePower = weightOrPower
        };
        catalog.Cars.Add(currentCar);
    }
    else
    {
        Truck currentTruck = new Truck()
        {
            Brand = brand,
            Model = model,
            Weight = weightOrPower
        };
        catalog.Trucks.Add(currentTruck);
    }
}


    Console.WriteLine("Cars:");
foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
{
    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
}
Console.WriteLine("Trucks:");
foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
{
    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
}
public class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Weight { get; set; }
}

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string HorsePower { get; set; }
}

public class Catalog
{
    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();

    }
    public List<Car> Cars { get; set; } 
    public List<Truck> Trucks { get; set; } 
}