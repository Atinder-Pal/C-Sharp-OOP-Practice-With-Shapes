using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Practice.Shapes
{
    abstract class Shape
    {
        abstract public double Area { get; }
        abstract public double Perimeter { get; }

        public string Colour { get; set; }

        public Shape()
        {
            Colour = "Black";            
        }
        public Shape( string colour )
        {
            Colour = colour;            
        }
    }
}
