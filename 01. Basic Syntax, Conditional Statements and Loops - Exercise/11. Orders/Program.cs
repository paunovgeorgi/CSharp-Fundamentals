int numOfOrders = int.Parse(Console.ReadLine());
double pricePerCapsule;
int numOfDays;
int capsulesCount;
double totalPrice = 0;

for (int i = 1; i <= numOfOrders; i++)
{
    double orderPrice = 0;
    pricePerCapsule = double.Parse(Console.ReadLine());
    numOfDays = int.Parse(Console.ReadLine());
    capsulesCount = int.Parse(Console.ReadLine());
    orderPrice = (numOfDays * capsulesCount) * pricePerCapsule;
    Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
    totalPrice += orderPrice;
}
Console.WriteLine($"Total: ${totalPrice:f2}");