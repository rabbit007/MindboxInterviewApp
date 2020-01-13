using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary.Shapes
{
    public class Rectangle : IShape
    {
        public double Length { get; }
        public double Width { get; }
        public Rectangle(double length, double width)
        {
            if (Length < 0)
                throw new ArgumentException("Length < 0");
            if (Width < 0)
                throw new ArgumentException("Width < 0");
            Length = length;
            Width = width;
        }
        public bool IsSquare()
        {
            return Length == Width;
        }
        public double GetArea()
        {
            return Length * Width;
        }
    }
}
