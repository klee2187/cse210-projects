using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square sA1 = new Square("blue", 8);
        shapes.Add(sA1);

        Rectangle rA1 = new Rectangle("yellow", 11, 5);
        shapes.Add(rA1);

        Circle cA1 = new Circle("purple", 10);
        shapes.Add(cA1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The area of the {color} shape is {area}.");
        }
    }
}