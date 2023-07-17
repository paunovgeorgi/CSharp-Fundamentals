namespace _1._Company_Roster
{
    public class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
            HighestDepartment = new List<string>();
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public List<string> HighestDepartment { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string department = input[2];
                employees.Add(new Employee(name, salary, department));
            }

            decimal highestIncome = 0;
            decimal currentIncome = 0;
            foreach (Employee employee in employees.OrderBy(x=>x.Department))
            {
                string currentEmployee = "";
                currentIncome = employee.Salary;
                if (employee.Department == currentEmployee)
                {
                    highestIncome += currentIncome;
                }
                string currnetDepartment = employee.Department;
            }

        }
    }
}