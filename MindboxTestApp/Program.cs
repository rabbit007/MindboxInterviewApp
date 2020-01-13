using System;
using CoreLibrary.Shapes;

namespace MindboxTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ShapeFactory();

            Console.WriteLine("Circles:");
            var circle1 = factory.CreateShape(10);
            Console.WriteLine($"Radius: 10, Area:{circle1.GetArea():N2}");

            Console.WriteLine("Rectangles:");
            var rect1 = factory.CreateShape(10, 10);
            Console.WriteLine($"Length: 10, Length: 10, Area:{rect1.GetArea():N2}, Is square: {((Rectangle)rect1).IsSquare()}");
            var rect2 = factory.CreateShape(20, 10);
            Console.WriteLine($"Length: 20, Length: 10, Area:{rect2.GetArea():N2}, Is square: {((Rectangle)rect2).IsSquare()}");

            Console.WriteLine("Trianglees:");
            var tr1 = factory.CreateShape(10, 10, 10);
            Console.WriteLine($"Side A: 10,Side B: 10,Side C: 10, Area:{tr1.GetArea():N2}, Is right: {((Triangle)tr1).IsRightTriangle()}");
            var tr2 = factory.CreateShape(3, 4, 5);
            Console.WriteLine($"Side A: 3,Side B: 4,Side C: 5, Area:{tr2.GetArea():N2}, Is right: {((Triangle)tr2).IsRightTriangle()}");

            Console.ReadLine();
        }
    }
}
