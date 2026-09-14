namespace Demo2
{
    public class Student
    {
        public object[] std = new object[5];

        public object this[int index]
        {
            get
            {
                return std[index];
            }
            set
            {
                std[index] = value;
            }
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
            student[3] = 3.8;
            student[4] = true;
            student[5] = false;

            Console.WriteLine("Student Name: " + student[0]);
            Console.WriteLine(student[1]);
        }
    }
}
