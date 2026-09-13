using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Basics
{
    internal class Veichle
    {
        public Veichle()
        {
            Console.WriteLine("This is a vehicle class constructor.");
        }
        public void Company_Name()
        {
            Console.WriteLine("Enter the company name of the vehicle: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Company Name: " + companyName);
        }
        public void Model_Name()
        {
            Console.WriteLine("Enter the model name of the vehicle: ");
            string modelName = Console.ReadLine();
            Console.WriteLine("Model Name: " + modelName);
        }
    }
}
