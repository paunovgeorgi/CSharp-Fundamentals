int numOfStudents = int.Parse(Console.ReadLine()); 
double totalNumOfLectures = int.Parse(Console.ReadLine());
int additionalBonus = int.Parse(Console.ReadLine());
int currentNumOfAttendences = 0;
double MaxBonus = 0;

for (int i = 1; i <= numOfStudents; i++)
{
    int attendances = int.Parse(Console.ReadLine());
    double totalBonus = Math.Round((attendances / totalNumOfLectures) * (5 + additionalBonus));

    if (totalBonus > MaxBonus)
    {
        MaxBonus = totalBonus;
        currentNumOfAttendences = attendances;
    }
}

Console.WriteLine($"Max Bonus: {MaxBonus}.");
Console.WriteLine($"The student has attended {currentNumOfAttendences} lectures.");

