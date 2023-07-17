int key = int.Parse(Console.ReadLine());
int numOfInputs = int.Parse(Console.ReadLine());
string password = "";

for (int i = 0; i < numOfInputs; i++)
{
    char input = char.Parse(Console.ReadLine());
    char pass = (char)(input + key);
    password += pass;
}
Console.WriteLine(password);