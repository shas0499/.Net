namespace Prac2
{
    public class Veicle
    {
        public object[] info = new object[3];

        public object this[object index]
        {
            get { return info[(int)index]; }
            set { info[(int)index] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Veicle veicle = new Veicle();
            veicle[0] = "Car";
            veicle[1] = 4;
            veicle[2] = "Red";

            Console.WriteLine("Type: {0}", veicle[0]);
            Console.WriteLine("Wheels: {0}", veicle[1]);
            Console.WriteLine("Color: {0}", veicle[2]);

        }
    }
}
