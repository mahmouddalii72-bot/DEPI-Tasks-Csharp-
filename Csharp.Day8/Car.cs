using Csharp.Day8.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day8
{
    public class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("the car start");
        }

        public void StopEngine()
        {
            Console.WriteLine("the car stop");

        }


    }

}
