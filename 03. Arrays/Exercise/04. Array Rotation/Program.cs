﻿string[] array = Console.ReadLine().Split();
int numOfRotations = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfRotations; i++)
{
    string firstElement = array[0];
    for (int j = 0; j < array.Length - 1; j++)
    {
        array[j] = array[j + 1];
    }
    array[array.Length - 1] = firstElement;
}

foreach (string number in array)
{
    Console.Write(number + " ");
}