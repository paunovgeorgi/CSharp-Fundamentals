
string input;
List<Student> register = new List<Student>();

while ((input = Console.ReadLine())!= "end")
{
    string[] info = input.Split();

    string firstName = info[0];
    string lastName = info[1];
    int age = int.Parse(info[2]);
    string hometown = info[3];

    Student student = new Student()
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        Hometown = hometown
    };

    register.Add(student);
}

string city = Console.ReadLine();

foreach (var student in register)
{
    if (student.Hometown == city)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}



class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Hometown { get; set; }
}