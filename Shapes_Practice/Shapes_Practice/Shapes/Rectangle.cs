using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Practice.Shapes
{
    //Illustrating Inheritence
    class Rectangle: Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double Perimeter
        {
            get => (2 * Length) + (2 * Width);           
        }
        public override double Area
        {
            get => (Length * Width);           
        }

        public Rectangle() : base()
        {
            Length = 2;
            Width = 3;
        }

        public Rectangle( string colour, double length, double width ):base(colour)
        {
            Length = length;
            Width = width;
        }
    }
}
