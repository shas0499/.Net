using System;

namespace AbstractClassandMethod
{
    // Simple demonstration of abstract class and method
    internal class Program
    {
        // Abstract base class defines a contract for calculation
        public abstract class Parameters
        {
            public int A { get; set; }
            public int B { get; set; }

            // Abstract method to be implemented by derived classes
            public abstract int Calculate();
        }

        // Concrete implementation that adds A and B
        public class Adder : Parameters
        {
            public override int Calculate()
            {
                return A + B;
            }
        }

        // Concrete implementation that multiplies A and B
        public class Multiplier : Parameters
        {
            public override int Calculate()
            {
                return A * B;
            }
        }

        static void Main(string[] args)
        {
            Parameters add = new Adder { A = 5, B = 3 };
            Parameters mul = new Multiplier { A = 5, B = 3 };

            Console.WriteLine($"Adder: {add.A} + {add.B} = {add.Calculate()}");
            Console.WriteLine($"Multiplier: {mul.A} * {mul.B} = {mul.Calculate()}");
        }
    }
}
