using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        // making a new list within the main program //
        List<Shape> shapes = new List<Shape>();
        
        Square square1 = new Square("Orange", 3);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Yellow", 2, 3);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Purple", 10);
        shapes.Add(circle1);

        // this is how we use polymorphism in programming with objects //

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
            Console.WriteLine("Have a nice day!");
        }


    }
}