using System.Reflection;
using Console = System.Console;

namespace _03._Speed_Racing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            TraveledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TraveledDistance { get; set; }

        public void CarMoves(double kmh)
        {
            if (kmh * FuelConsumption <= FuelAmount)
            {
                    FuelAmount -= kmh * FuelConsumption;
                    TraveledDistance += kmh;
            }
            else
            {
                    Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse((Console.ReadLine()));
            List<Car> cars = new List<Car>();


            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);
                Car currentCar = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(currentCar);
            }
            string input;
            while ((input = Console.ReadLine())!= "End")
            {
                string[] action = input.Split();
                string model = action[1];
                double kmh = double.Parse(action[2]);

                foreach (Car car in cars)
                    {
                        if (model == car.Model)
                        {
                            car.CarMoves(kmh);
                            break;
                        }
                    }
            }
            foreach (var car in cars)
           {
               Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
           }
        }
    }
}