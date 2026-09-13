using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Obj
{
    internal class Car
    {
        // Constructor
        public Car(string model, string brand, int prices)
        {
            Console.WriteLine($"Car Brand : {brand} model is : {model} Onroad price : {prices}");
        }
    }
}
