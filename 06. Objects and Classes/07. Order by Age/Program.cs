using System.Security.Cryptography.X509Certificates;

namespace _07._Order_by_Age
{
    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> register = new List<Person>();
            string input;
            while ((input = Console.ReadLine())!= "End")
            {
                string[] info = input.Split();
                string name = info[0];
                string iD = info[1];
                int age = int.Parse(info[2]);
                Person currentPerson = new Person(name, iD, age);
                Person idCheck = register.Find(x => x.Id.Contains(iD));
                if (idCheck != null)
                {
                    currentPerson.Name = name;
                    currentPerson.Age = age;
                }
                register.Add(currentPerson);
            }

            foreach (var person in register.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}