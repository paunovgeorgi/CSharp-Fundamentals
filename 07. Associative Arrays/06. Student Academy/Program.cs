int n = int.Parse(Console.ReadLine());
var students = new Dictionary<string, Grade>();
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(name))
    {
        students.Add(name, new Grade(0, 0));
    }
    students[name].Grades += grade;
    students[name].Count++;
}
var finalList = students.Where(x => x.Value.AverageGrade >= 4.50)
    .ToDictionary(x => x.Key, x => x.Value);
foreach (var student in finalList)
{
    Console.WriteLine($"{student.Key} -> {student.Value.AverageGrade:f2}");
}

public class Grade
{
    public Grade(double grades, int count)
    {
        Grades = grades;
        Count = count;
    }

    public double Grades { get; set; }
    public int Count { get; set; }

    public double AverageGrade
    {
        get { return Grades / Count; }
    }
}