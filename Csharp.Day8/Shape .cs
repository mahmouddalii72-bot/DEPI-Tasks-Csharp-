using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day8
{
    class Shape2 : IComparable<Shape2>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape2(string name, double area)
        {
            Name = name;
            Area = area;
        }

        
        public int CompareTo(Shape2 other)
        {
            return this.Area.CompareTo(other.Area);
        }

        public override string ToString()
        {
            return $"Shape: {Name}, Area: {Area}";
        }
    }
}
