using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day7
{
    internal class Car
    {
        public int id;
        public string brand;
        public double price;

        public Car()
        {
            id = 0;
            brand = "unknown";
            price = 0;

        }

        public Car(int id) 
        { 
            id = id;
            brand = "unknown";
            price = 0;
        }

        public Car(int id,string brand)
        {
            id = id;
            brand = brand;
            price = 0;
        }

        public Car(int id,string brand,double price)
        {
            id = id;
            brand = brand;
            price = price;
        }

        public override string ToString()
        {
            return $"Id: {id}, Brand: {brand}, Price: {price}";
        }
    }
}
