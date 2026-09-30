using System.Threading;
using System.Xml.Serialization;

namespace MultiThreadingDemo
{
    internal class Program
    {
        static void PrintNum(object num)
        {
            for (int i = 0; i < (int)num; i++)
            {
                Console.WriteLine($"Thread : {i}");
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintNum);
            thread.Start(5); // Start the thread with an argument of 5
            
        }
    }
}
