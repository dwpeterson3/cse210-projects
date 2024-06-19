using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square  square = new Square(5, "Green"); 
        Console.WriteLine(square.GetColor()); 
        Console.WriteLine(square.GetArea());
        Rectangle rectangle = new Rectangle(2, 2, "Blue"); 
        Circle circle = new Circle(5, "Purple"); 

        Console.WriteLine(rectangle.GetColor()); 
        Console.WriteLine(rectangle.GetArea());

        Console.WriteLine(circle.GetColor()); 
        Console.WriteLine(circle.GetArea());

         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine();
        

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(10, "Yellow")); 
        shapes.Add(new Rectangle(10, 5, "Red")); 
        shapes.Add(new Circle(10, "Aquamarine")); 


        foreach(Shape shape in shapes)
        {
            string shapeColor = shape.GetColor();
            double shapeArea = shape.GetArea(); 
            Console.WriteLine($"The square area equals {shapeArea} and the color is {shapeColor}!");
            Console.WriteLine();             
        }

    
    }
}