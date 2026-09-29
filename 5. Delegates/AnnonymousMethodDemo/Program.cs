namespace AnnonymousMethodDemo
{
    internal class Program
    {
        // This is a delegate declaration
        delegate void ShowMessage(string message);
        static void Main(string[] args)
        {
            // This is an anonymous method that is assigned to the delegate. 
            // The anonymous method takes a string parameter and writes it to the console.
            ShowMessage msg = delegate (string message)
            {
                Console.WriteLine("Hello Delegate...." + message);
            };
            msg("Welcome to C# Programming");
        }
    }
}
