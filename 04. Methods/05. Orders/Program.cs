string item = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
Order(item, quantity);
static void Order(string item, int quantity)
{
double price = 0;
switch (item)
    {
        case "coffee": price += 1.5 * quantity;
            break;
        case "water":
            price += 1 * quantity;
            break;
        case "coke":
            price += 1.4 * quantity;
            break;
        default:
            price += 2.00 * quantity;
            break;
    }
    Console.WriteLine($"{price:f2}");
}