using System;
using VectorDrawing;

class Program
{
    static void Main()
    {
        // Create a drawing and pass new shapes as parameters
        Drawing drawing = new Drawing(new IShape[]
        {
            new Rectangle(10, 10, 30, 40),
            new Square(15, 30, 35),
            new Ellipse(100, 150, 300, 200),
            new Circle(1, 1, 300),
            new Textbox(5, 5, 200, 100, "sample text")
        });

        // Print details of all shapes in the drawing to the console
        drawing.Print();

        Console.ReadLine();
    }
}

