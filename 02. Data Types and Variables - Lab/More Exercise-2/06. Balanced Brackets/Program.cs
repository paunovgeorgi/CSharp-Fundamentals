int numOfLines = int.Parse(Console.ReadLine());
int counter = 0;
int secondCounter = 0;
int negativeCounter = 0;

for (int i = 0; i < numOfLines; i++)
{
    string input = Console.ReadLine();
    if (input == "(" && counter == secondCounter)
    {
        counter++;
    }
    else if (input == "(" && counter != secondCounter)
    {
        negativeCounter++;
    }
       
    if (input == ")" && counter > secondCounter)
    {
        secondCounter++;
    }
    else if (input == ")" && counter <= secondCounter)
    {
        negativeCounter++;
    }

}
if (negativeCounter > 0)
{
    Console.WriteLine("UNBALANCED");
    return;
}
if (counter == secondCounter)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}