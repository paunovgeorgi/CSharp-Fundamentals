int number = int.Parse(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine(sum);

/* Another version:
int num = int.Parse(Console.ReadLine());

string number = num.ToString();
int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    sum += int.Parse(number[i].ToString());
}

//Console.WriteLine(sum);
*/
