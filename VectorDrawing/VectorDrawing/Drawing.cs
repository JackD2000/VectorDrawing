using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing
{
    // Class used to store widgets as one drawing
    internal class Drawing
    {
        // Array containing every shape in the drawing
        public IShape[] Shapes { get; set; }

        // Constructor for drawing objects
        // Takes array of shapes as argument
        public Drawing(IShape[] shapes)
        {
            Shapes = shapes;
        }

        // Prints details of every shape in the drawing, if Shapes array is not empty
        public void Print()
        {
            Console.WriteLine("----------------------------------------------------------------\nRequested Drawing\n----------------------------------------------------------------");

            if (Shapes.Length > 0)
            {
                foreach (IShape shape in Shapes)
                {
                    shape.Print();
                }
            }
            else
            {
                Console.WriteLine("Drawing has no shapes.");
            }

            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
