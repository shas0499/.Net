namespace InterfaceP1
{
    internal class Program
    {
        interface IShape
        {
            double Area();
        }
        class Circle : IShape
        {
            private double radius;
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double Area()
            {
                return Math.PI * radius * radius;
            }
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            double area = circle.Area();
            Console.WriteLine($"Area of the circle: {area}");
        }
    }
}
