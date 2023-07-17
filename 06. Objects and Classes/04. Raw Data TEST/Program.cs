namespace _04._Raw_Data_TEST
{
    public class Car
    {
        public Car(string model, double speed,double power, double weight, string type)
        {
            Model = model;
            engine = new Engine(speed, power);
            cargo = new Cargo(weight, type);
        }
        public string Model { get; set; }
        public Engine engine { get; set; }
        public Cargo cargo { get; set; }
        
    }
    public class Cargo
    {
        public Cargo(double weight, string type)
        {
            Weight = weight;
            Type = type;
        }
        public double Weight { get; set; }
        public string Type { get; set; }
    }
    public class Engine
    {
        public Engine(double speed, double power)
        {
            Power = power;
            Speed = speed;
        }
        public double Power { get; set; }
        public double Speed { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double speed = double.Parse(input[1]);
                double power = double.Parse(input[2]);
                double weight = double.Parse(input[3]);
                string type = input[4];
               
                Car newCar = new Car(model, speed, power, weight, type);
                cars.Add(newCar);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (Car car in cars.Where(x => x.cargo.Type == "fragile"))
                {
                    if (car.cargo.Weight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                foreach (Car car in cars.Where(x => x.cargo.Type == "flamable"))
                {
                    if (car.engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}