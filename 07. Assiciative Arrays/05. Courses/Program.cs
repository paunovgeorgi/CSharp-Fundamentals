var courses = new Dictionary<string, List<string>>();
string input;
while ((input = Console.ReadLine())!= "end")
{
    string[] courseAndName = input.Split(" : ");
    string courseName = courseAndName[0];
    string studentName = courseAndName[1];
    if (!courses.ContainsKey(courseName))
    {
        courses.Add(courseName, new List<string>());
    }
    courses[courseName].Add(studentName);
}
foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");
    Console.WriteLine(string.Join(Environment.NewLine, course.Value.Select(x => $"-- {x}"))); 
}