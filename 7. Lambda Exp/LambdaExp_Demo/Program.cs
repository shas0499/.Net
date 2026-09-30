namespace LambdaExp_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lambda expression to calculate the square of a number
            Func<int, int> square = x => x * x;

            int number = 5;
            int result = square(number);
            Console.WriteLine($"The square of {number} is {result}");

        }
    }
}
