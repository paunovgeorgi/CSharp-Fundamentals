double totalWithoutTaxes = 0;
double taxes = 0;
string command;

while ((command = Console.ReadLine()) != "special" && command != "regular")
{
    double price = double.Parse(command);
    if (price <= 0)
    {
        Console.WriteLine("Invalid price!");
        continue;
    }
    totalWithoutTaxes += price;
    taxes = taxes + (price * 0.2);
}

if (totalWithoutTaxes == 0)
{
    Console.WriteLine("Invalid order!");
}

else
{
    double totalWithTaxes = totalWithoutTaxes + taxes;

    if (command == "special")
    {
        totalWithTaxes *= 0.9;
    }
    Console.WriteLine("Congratulations you've just bought a new computer!");
    Console.WriteLine($"Price without taxes: {totalWithoutTaxes:f2}$");
    Console.WriteLine($"Taxes: {taxes:f2}$");
    Console.WriteLine("-----------");
    Console.WriteLine($"Total price: {totalWithTaxes:f2}$");
}


