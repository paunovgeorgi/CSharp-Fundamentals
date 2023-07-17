string input = Console.ReadLine();

DetermineDataType(input);
void DetermineDataType(string input)
{
    switch (input)
    {
        case "int":
            int num = int.Parse(Console.ReadLine()) * 2;
            Console.WriteLine(num);
            break;
        case "real":
            double numDouble = double.Parse(Console.ReadLine()) * 1.5;
            Console.WriteLine($"{numDouble:f2}");
            break;
        case "string":
            string inputSrt = Console.ReadLine();
            Console.WriteLine($"${inputSrt}$");
            break;
    }
}







