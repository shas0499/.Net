namespace LambdaExpWithoutPredefineDelegates
{
    internal class Program
    {
        public delegate int NumberOperation(int x, int y);
        static void Main(string[] args)
        {
            NumberOperation sum = (x, y) => x + y;
            NumberOperation sub = (x, y) => x - y;

            Console.WriteLine("Sum: " + sum(5, 3));
            Console.WriteLine("Sub: " + sub(5, 3));
        }
    }
}
