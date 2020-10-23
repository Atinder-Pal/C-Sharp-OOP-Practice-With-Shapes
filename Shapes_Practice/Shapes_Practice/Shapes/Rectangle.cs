using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Practice.Shapes
{
    class Rectangle: Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double Perimeter
        {
            get
            {
                return (2 * Length) + (2 * Width);
            }
        }
        public override double Area
        {
            get
            {
                return (Length * Width);
            }
        }
    }
}
