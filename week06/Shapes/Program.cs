using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test individual classes
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle Color: {circle.GetColor()}");
        Console.WriteLine($"Circle Area: {circle.GetArea():F2}");

        Console.WriteLine();

        // Create list of shapes
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Yellow", 4));
        shapes.Add(new Rectangle("Purple", 3, 7));
        shapes.Add(new Circle("Orange", 2.5));

        // Iterate through list
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            Console.WriteLine();
        }
    }
}