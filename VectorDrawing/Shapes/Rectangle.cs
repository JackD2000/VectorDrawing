using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing
{
    internal class Rectangle : IShape
    {
        // Properties required by interface
        public int X { get; set; }
        public int Y { get; set; }

        // Shape-specific properties
        public int Width { get; set; }
        public int Height { get; set; }

        // Constructor for rectangle objects
        // Assigns values to all fields
        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;

            // Throws exception if shape dimensions are not valid
            if (width >= 0 && height >= 0)
            {
                Width = width;
                Height = height;
            }
            else
            {
                throw new ArgumentException("Rectangle dimensions are invalid.");
            }
        }

        // Uses string interpolation to print rectangle's details to console
        public void Print()
        {
            Console.WriteLine($"Rectangle ({X},{Y}) width={Width} height={Height}");
        }
    }
}
