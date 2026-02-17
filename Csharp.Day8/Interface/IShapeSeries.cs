using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day8.Interface
{
    interface IShapeSeries
    {
        public int CurrentShapeArea { get; set; }

        void GetNextArea();

        void ResetSeries();


        class SquareSeries : IShapeSeries
        {

            private int side = 0;

            public int CurrentShapeArea { get; set; }

            public void GetNextArea()
            {
                side++;
                CurrentShapeArea = side * side;
            }

            public void ResetSeries()
            {
                side = 0;
                CurrentShapeArea = 0;
            }
        }

        public class CircleSeries : IShapeSeries
        {
            private int radius = 0;

            public int CurrentShapeArea { get; set; }

            public void GetNextArea()
            {
                radius++;
                CurrentShapeArea = (int)(Math.PI * radius * radius);
            }

            public void ResetSeries()
            {
                radius = 0;
                CurrentShapeArea = 0;
            }

        }
    }
}