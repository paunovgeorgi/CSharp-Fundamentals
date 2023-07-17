

double AvailableMoney = double.Parse(Console.ReadLine());
int numOfStudents = int.Parse(Console.ReadLine());
double lightSaberPrice = double.Parse(Console.ReadLine());
double robesPrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());
int counter = 0;

if (numOfStudents >= 6)
{
    for (int i = 1; i <= numOfStudents; i++)
    {
        if (i % 6 == 0)
        {
            counter++;
        }
    }
}

double lightsabers = Math.Ceiling(numOfStudents * 1.1) * lightSaberPrice;

double totalPrice =  lightsabers + numOfStudents * (robesPrice + beltPrice) - beltPrice * counter;

if (AvailableMoney >= totalPrice)
{
    Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {totalPrice - AvailableMoney:f2}lv more.");
}




