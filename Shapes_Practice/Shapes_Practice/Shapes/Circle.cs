using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Practice.Shapes
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public double Diameter
        { 
            get
            {
                return Radius * 2;
            }
        }

        public override double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
        public override double Perimeter
        {
            get
            {
                return Math.PI * Diameter;
            }
        }
        public Circle( string colour, double radius ): base( colour )
        {
            Radius = radius;
        }
    }
}
