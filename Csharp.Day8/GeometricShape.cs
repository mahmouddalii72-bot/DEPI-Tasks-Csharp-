using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day8
{
    abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public GeometricShape(double dim1, double dim2)
        {
            Dimension1 = dim1;
            Dimension2 = dim2;
        }

        // Abstract Method
        public abstract double CalculateArea();

        // Abstract Property
        public abstract double Perimeter { get; }

        public void Display()
        {
            Console.WriteLine($"Area = {CalculateArea()}");
            Console.WriteLine($"Perimeter = {Perimeter}");
            Console.WriteLine("----------------------");
        }
    }

    class Triangle : GeometricShape
    {
        public Triangle(double baseLength, double height)
            : base(baseLength, height)
        {
        }

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        // للتبسيط هنحسب Perimeter تقريبي (مش دقيق هندسيًا)
        public override double Perimeter
        {
            get
            {
                return Dimension1 + Dimension2 +
                       Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
            }
        }
    }

class Rectangle2 : GeometricShape
    {
        public Rectangle2(double length, double width)
            : base(length, width)
        {
        }

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Dimension1 + Dimension2);
            }
        }
    }
}
