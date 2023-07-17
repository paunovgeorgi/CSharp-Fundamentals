using System.Globalization;
using System.Transactions;

namespace _06._Vehicle_Catalogue__2
{
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public override string ToString()
        {
            string output = "";
            output += $"Type: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Type)}\n";
            output += $"Model: {Model}\n";
            output += $"Color: {Color}\n";
            output += $"Horsepower: {HorsePower}\n";
            return output.Trim();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehiclesCatalogue = new List<Vehicle>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleInfo = input.Split();
                string vehicleType = vehicleInfo[0];
                string vehicleModel = vehicleInfo[1];
                string vehicleColor = vehicleInfo[2];
                double vehicleHP = double.Parse(vehicleInfo[3]);
                Vehicle currentVehicle = new Vehicle(vehicleType, vehicleModel, vehicleColor, vehicleHP);
                vehiclesCatalogue.Add(currentVehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var vehicle in vehiclesCatalogue)
                {
                    if (input == vehicle.Model)
                    {
                        Console.WriteLine(vehicle);
                    }
                }
            }

            double totalCarHp = 0;
            double totalTruckHp = 0;
            double carCount = 0;
            double truckCount = 0;
            foreach (var vehicle in vehiclesCatalogue)
            {
                if (vehicle.Type == "car")
                {
                    carCount++;
                    totalCarHp += vehicle.HorsePower;
                }
                else if (vehicle.Type == "truck")
                {
                    truckCount++;
                    totalTruckHp += vehicle.HorsePower;
                }
            }

            if(totalCarHp > 0)
            {
                totalCarHp /= carCount;
            }

            if (totalTruckHp > 0)
            {
                totalTruckHp /= truckCount;
            }
            Console.WriteLine($"Cars have average horsepower of: {totalCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {totalTruckHp:f2}.");
        }
    }
}