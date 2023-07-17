static void StudentGrade(double grade)
{
    if (grade >= 5.50)
    {
        Console.WriteLine("Excellent");
    }
    else if (grade >= 4.50)
    {
        Console.WriteLine("Very good");
    }
    else if (grade >= 3.50)
    {
        Console.WriteLine("Good");
    }
    else if (grade >= 3)
    {
        Console.WriteLine("Poor");
    }
    else
    {
        Console.WriteLine("Fail");
    }
}
double grade = double.Parse(Console.ReadLine());
StudentGrade(grade);