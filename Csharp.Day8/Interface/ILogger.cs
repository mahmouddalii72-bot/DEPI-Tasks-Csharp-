using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day8.Interface
{
    internal interface ILogger
    {
        void Log(string message)
        {
            Console.WriteLine($"Default Log: {message}");
        }

       
        class DefaultLogger : ILogger
        {
            
        }
    }
}
