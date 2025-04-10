using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        List<Shape> shapes = new List<Shape>();
        Square square = new Square("blue", 7);
        Rectangle rectangle = new Rectangle("Red", 8, 4);
        Circle circle = new Circle("Yellow", 3);
        
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}