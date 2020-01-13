using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary.Shapes
{
    public class ShapeFactory
    {
        public IShape CreateShape(double a)
        {
            return new Circle(a);
        }
        public IShape CreateShape(double a, double b)
        {
            return new Rectangle(a, b);
        }
        public IShape CreateShape(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
    }
}
