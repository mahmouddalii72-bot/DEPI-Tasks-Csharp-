using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day7
{
    internal interface IShape
    {
        double Area { get; }   
        void Draw();

        // Default implementation (C# 8.0+)
        void PrintDetails()
        {
            Console.WriteLine($"Shape Area = {Area}");
        }
    }
}

public interface IReadable
{
    void Read();
}

public interface IWritable
{
    void Write();
}
