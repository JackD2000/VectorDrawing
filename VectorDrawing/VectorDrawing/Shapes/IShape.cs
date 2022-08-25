using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDrawing
{
    // Interface implemented by all shape widgets
    internal interface IShape
    {
        // Properties used to set coordinates for each shape
        int X { get; set; }
        int Y { get; set; }

        // Method for printing details of a shape to the console
        void Print();
    }
}
