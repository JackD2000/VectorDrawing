using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing
{
    internal class Ellipse : IShape
    {
        // Properties required by interface
        public int X { get; set; }
        public int Y { get; set; }

        // Shape-specific properties
        public int DiameterH { get; set; }
        public int DiameterV { get; set; }

        // Constructor for ellipse objects
        // Assigns values to all fields
        public Ellipse(int x, int y, int diameterH, int diameterV)
        {
            X = x;
            Y = y;

            // Throws exception if shape dimensions are not valid
            if (diameterH >= 0 && diameterV >= 0)
            {
                DiameterH = diameterH;
                DiameterV = diameterV;
            }
            else
            {
                throw new ArgumentException("Ellipse dimensions are invalid.");
            }
        }

        // Uses string interpolation to print ellipse's details to console
        public void Print()
        {
            Console.WriteLine($"Ellipse ({X},{Y}) diameterH={DiameterH} diameterV={DiameterV}");
        }
    }
}
