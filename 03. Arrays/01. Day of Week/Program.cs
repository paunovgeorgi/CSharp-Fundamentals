string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek >= 1 && dayOfWeek <= weekDays.Length)
{
    Console.WriteLine($"{weekDays[dayOfWeek - 1]}");
}
else
{
    Console.WriteLine("Invalid day!");
}

