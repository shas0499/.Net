namespace Prob3
{
    internal class Program
    {
        public object[] Employee = new object[3];

        public object this[int index]
        {
            get
            {
                return Employee[index];
            }
            set
            {
                Employee[index] = value;
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program[0] = "John Doe";
            program[1] = "Jane Smith";
            program[2] = "Bob Johnson";

            Console.WriteLine("Names:"+program[0]+", "+program[1]+", "+program[2]);
        }
    }
}
