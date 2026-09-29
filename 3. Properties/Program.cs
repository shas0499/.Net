namespace PropertiesDemo
{
    public class Circle
    {
        double radius = 32.34;
        public double getRadius()
        {
            return radius;
        }
        public double setRadius(double radius)
        {
            this.radius = radius; // this keyword is used to refer to the current instance of the class
            return radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.setRadius(10.5);
            Console.WriteLine("Radius: " + circle.getRadius());
        }
    }
}
