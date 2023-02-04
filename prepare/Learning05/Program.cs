using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 10);

        Rectangle rectangle = new Rectangle("green", 12, 15.5);

        Circle circle = new Circle("purple", 22);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}