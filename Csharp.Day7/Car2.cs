using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day7
{
  
        public class Car2 : IMovable
        {
            public string Brand { get; set; }

            public Car2(string brand)
            {
                Brand = brand;
            }

            public void Move()
            {
                Console.WriteLine($"{Brand} is moving...");
            }
        }
    }

