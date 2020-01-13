using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius < 0");
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
