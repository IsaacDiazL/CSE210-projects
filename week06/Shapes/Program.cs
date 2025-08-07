using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("red", 4.0f);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("blue", 5.0f, 3.0f);
        shapes.Add(rectangle);
        Circle circle = new Circle("green", 5.0f);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            DisplayShapeInfo(shape);
        }
    }

    public static void DisplayShapeInfo(Shape shape)
    {
        Console.WriteLine($"The area of the {shape.GetColor()} shape is: {shape.GetArea()}");
    }
}