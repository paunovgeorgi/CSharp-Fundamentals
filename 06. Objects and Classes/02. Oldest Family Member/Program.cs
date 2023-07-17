using System.Reflection.PortableExecutable;

namespace _02._Oldest_Family_Member
{

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public string GetOldersMember(Family newMember)
        {
            string oldersMember = "";
            foreach (Person person in newMember.People.OrderByDescending(x => x.Age))
            {
                oldersMember = person.Name + " " + person.Age;
                break;
            }
            return oldersMember;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Family currentFamily = new Family();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                currentFamily.AddMember(new Person(name, age));
            }
            Console.WriteLine(currentFamily.GetOldersMember(currentFamily));
        }
    }
}