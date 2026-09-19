namespace MethodOverloading
{
    internal class Program
    {
        public void Method()
        {
            Console.WriteLine("Method 1 Call..");
        }
        public void Method(string name)
        {
            Console.WriteLine($"{name}");
        }
        public void Method(int age, string city)
        {
            Console.WriteLine($"{age} {city}");
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Method();
            p.Method("Shaswata");
            p.Method(27, "Kolkata");
        }
    }
}
