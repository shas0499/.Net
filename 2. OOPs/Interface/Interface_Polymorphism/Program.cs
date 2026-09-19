namespace Interface_Polymorphism
{
    internal class Program
    {
        // Interface
        public interface IAnimal
        {
            void MakeSound();
            void Eat();
        }

        public class Cat : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Meow");
            }
            public void Eat()
            {
                Console.WriteLine("The cat is eating.");
            }
        }
        static void Main(string[] args)
        {
            IAnimal animal = new Cat();
            animal.MakeSound();
            animal.Eat();

            Console.WriteLine("Hello, World!");
        }
    }
}
