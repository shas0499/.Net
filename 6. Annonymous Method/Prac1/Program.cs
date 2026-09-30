namespace Prac1
{
    internal class Program
    {
        delegate void StudentInfo(string name, int rollno, string dept);
        static void Main(string[] args)
        {
            StudentInfo std = delegate(string name, int rollno, string dept)
            {
                Console.WriteLine($"Name: {name}, Roll No: {rollno}, Department: {dept}");
            };
            std("John Doe", 123, "Computer Science");
        }
    }
}
