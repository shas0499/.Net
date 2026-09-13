using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Basics
{
    internal class TwoWheeler : Veichle
    {
        public TwoWheeler()
        {
            Console.WriteLine("This is a two-wheeler class constructor.");
        }
        public void Veichle_type()
        {
            Console.WriteLine("This is a two-wheeler vehicle.");
        }
        public void TwoWheeler_type()
        {
            Console.WriteLine("Enter the type of two-wheeler vehicle (e.g., Motorcycle, Scooter): ");
            string twoWheelerType = Console.ReadLine();
            Console.WriteLine("Two-Wheeler Type: " + twoWheelerType);
        }
    }
}
