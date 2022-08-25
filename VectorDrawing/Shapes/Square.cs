using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing
{
    internal class Square : IShape
    {
        // Properties required by interface
        public int X { get; set; }
        public int Y { get; set; }

        // Shape-specific properties
        public int Size { get; set; }

        // Constructor for square objects
        // Assigns values to all fields
        public Square(int x, int y, int size)
        {
            X = x;
            Y = y;

            // Throws exception if shape dimensions are not valid
            if (size >= 0)
            {
                Size = size;
            }
            else
            {
                throw new ArgumentException("Square dimensions are invalid.");
            }
        }

        // Uses string interpolation to print square's details to console
        public void Print()
        {
            Console.WriteLine($"Square ({X},{Y}) size={Size}");
        }
    }
}
