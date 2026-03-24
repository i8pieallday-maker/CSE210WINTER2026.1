using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 4));
        shapes.Add(new Rectangle("blue", 4, 2));
        shapes.Add(new Circle("yellow", 4));
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}