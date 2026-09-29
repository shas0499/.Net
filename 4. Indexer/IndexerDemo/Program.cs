namespace IndexerDemo
{
    public  class Employee
    {
        public object[] values = new object[3];

        public object this[int index]
        {
            get
            {
                return values[index];
            }
            set { values[index] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp[0] = "John Doe";
            emp[1] = 30;
            emp[2] = "Software Engineer";

            Console.WriteLine("Employee Name: " + emp[0]);
            Console.WriteLine("Employee Age: " + emp[1]);
            Console.WriteLine("Employee Designation: " + emp[2]);
        }
    }
}
