namespace ad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Ivan", 2300),
                new Employee("Maria", 1900),
                new Employee("Sofia", 3000),
                new Employee("Aleksandar", 2600),
                new Employee("Jordan", 1700)
            };
            Company company = new Company(employees);
            Console.WriteLine("Въведете заплата за търсене: ");
            int salary = int.Parse(Console.ReadLine());
            string result = company.FindEmployeeBySalary(salary);
            Console.WriteLine("Име на човека с тази заплата: " + result);
            Console.ReadKey();
        }
    }
}
