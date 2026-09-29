namespace Prac1
{
    public class Student
    {
        public object[] info = new object[3];

        public object this[int index]
        {
            get { return info[index]; }
            set { info[index] = value; }
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Student student = new Student();

            student[0] = "John Doe";
            student[1] = 20;
            student[2] = "Computer Science";

            Console.WriteLine($"Name: {student[0]}");
            Console.WriteLine("Age: " + student[1]);
            Console.WriteLine("Department: " + student[2]);
        }
    }
}
