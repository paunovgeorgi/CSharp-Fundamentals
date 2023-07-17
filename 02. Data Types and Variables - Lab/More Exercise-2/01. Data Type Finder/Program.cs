using System;
using System.ComponentModel.DataAnnotations;

string input = "";

int dataInt;
double dataFloat;
char dataChar;
bool dataBool;

while ((input = Console.ReadLine()) != "END")
{
    if (int.TryParse(input, out dataInt))
	{
        Console.WriteLine($"{input} is integer type");
    }
    else if (double.TryParse(input, out dataFloat))
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else if (char.TryParse(input, out dataChar))
    {
        Console.WriteLine($"{input} is character type");
    }
    else if (bool.TryParse(input, out dataBool))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }
}