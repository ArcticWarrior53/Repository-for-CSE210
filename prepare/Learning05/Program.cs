using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle("Purple", 12);
        Square square1 = new Square("Yellow", 3);
        Rectangle rectangle1 = new Rectangle("Navy Green", 2, 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(circle1);
        shapes.Add(rectangle1);

        foreach (Shape s in shapes)
            {
                // Notice that all shapes have a GetColor method from the base class
                string color = s.GetColor();

                // Notice that all shapes have a GetArea method, but the behavior is
                // different for each type of shape
                double area = s.GetArea();

                Console.WriteLine($"The {color} shape has an area of {area}.");
            }
    }
}