namespace _04._Students___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);
                students.Add(new Student(firstName, lastName, grade));
            }

            foreach (Student student in students.OrderByDescending(x=>x.Grade))
            {
                Console.WriteLine(student);
            }
        }


//• First name(string)
//• Last name(string)
//• Grade(a floating-point number)
        public class Student
        {
            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            private string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }


    }
}