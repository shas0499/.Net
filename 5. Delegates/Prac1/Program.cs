namespace Prac1
{
    internal class Program
    {
        public delegate void Employee(int id, string name, double salary);

        public static void EmpInfo(int id, string name, double salary)
        {
            Console.WriteLine("Name : "+name);
            Console.WriteLine("ID : "+id);
            Console.WriteLine("Salary : "+salary);
        }
        static void Main(string[] args)
        {
            Employee employee = EmpInfo;
            Employee employee2 = employee;

            employee(1, "John", 50000);
            employee2(2, "Jane", 60000);
        }
    }
}
