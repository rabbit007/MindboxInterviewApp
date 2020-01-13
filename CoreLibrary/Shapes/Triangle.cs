using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary.Shapes
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double Alfa { get; }
        public double Beta { get; }
        public double Gamma { get; }
        public Triangle(double a, double b, double с)
        {
            if (A < 0)
                throw new ArgumentException("A < 0");
            if (B < 0)
                throw new ArgumentException("B < 0");
            if (C < 0)
                throw new ArgumentException("C < 0");
            A = a;
            B = b;
            C = с;
            Alfa = Math.Acos((Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) / 2 * B * C) * 180 / Math.PI;
            Beta = Math.Acos((Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) / 2 * A * C) * 180 / Math.PI;
            Gamma = Math.Acos((Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) / 2 * A * B) * 180 / Math.PI;
        }
        public double GetArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public bool IsRightTriangle()
        {
            return Alfa == 90 || Beta == 90 || Gamma == 90;
        }
    }
}
