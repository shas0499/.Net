namespace DelegatesExample
{
    internal class Program
    {
        // Initialize a delegate that takes a string parameter and returns void
        public delegate void Name(string name);

        // Method that matches the delegate signature
        public static void MyName(string name)
        {
            Console.WriteLine($"My name is {name}");
        }
        static void Main(string[] args)
        {
            // Create an instance of the delegate and assign the method to it
            Name nameDelegate = new Name(MyName);
            nameDelegate("John Doe");
        }
    }
}
