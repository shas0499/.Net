namespace Prac2
{
    internal class Program
    {
        public delegate void Student(string name, int rollno, string branch);

        public static void std(string name, int rollno, string branch)
        {
            Console.WriteLine("Name: {0}, Roll No: {1}, Branch: {2}", name, rollno, branch);
        }
        static void Main(string[] args)
        {
            Student student = std;
            student("John Doe", 123, "Computer Science");
        }
    }
}
