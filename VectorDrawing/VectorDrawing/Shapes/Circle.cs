using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing
{
    internal class Circle : IShape
    {
        // Properties required by interface
        public int X { get; set; }
        public int Y { get; set; }

        // Shape-specific properties
        public int Diameter { get; set; }

        // Constructor for circle objects
        // Assigns values to all fields
        public Circle(int x, int y, int diameter)
        {
            X = x;
            Y = y;

            // Throws exception if shape dimensions are not valid
            if (diameter >= 0)
            {
                Diameter = diameter;
            }
            else
            {
                throw new ArgumentException("Circle dimensions are invalid.");
            }
        }

        // Uses string interpolation to print circle's details to console
        public void Print()
        {
            Console.WriteLine($"Circle ({X},{Y}) size={Diameter}");
        }
    }
}
