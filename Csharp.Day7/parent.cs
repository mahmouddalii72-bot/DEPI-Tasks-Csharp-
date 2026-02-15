using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day7
{
    public class parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public parent(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Parent Constructor Called");
        }

        public virtual int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }

    public class Child : parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("Child Constructor Called");
        }

        // by new 
        //public new int Product()
        //{
        //    return X * Y * Z;
        //}

        // by override
        public override int Product()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Z = {Z}";
        }
    }
}
