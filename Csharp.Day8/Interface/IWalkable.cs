using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day8.Interface
{
    interface IWalkable
    {
        void Walk();
    }

    class Robot : IWalkable
    {
        // Method عادية خاصة بالـ Robot
        public void Walk()
        {
            Console.WriteLine("Robot is walking using wheels.");
        }

        // Explicit Interface Implementation
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking like a human.");
        }
    }

}
