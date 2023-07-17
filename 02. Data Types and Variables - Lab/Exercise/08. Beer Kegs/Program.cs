int numOfKegs = int.Parse(Console.ReadLine());
double biggestKen = double.MinValue;
string currentModel = "";

for (int i = 0; i < numOfKegs; i++)

{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double kenSize = Math.PI * Math.Pow(radius, 2) * height;

    if (kenSize > biggestKen)
    {
        biggestKen = kenSize;
        currentModel = model;
    }

}

Console.WriteLine(currentModel);