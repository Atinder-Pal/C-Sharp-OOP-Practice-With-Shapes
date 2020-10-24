using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Practice.Shapes
{
    class Triangle: Shape
    {
        public Double Base { get; set; }
        public Double Height { get; set; }
        public override double Perimeter
        {
            get => Base * 3;         
        }

        public override double Area
        {
            get => (Base * Height) / 2;          
        }

        public Triangle() : base()
        {
            Base = 4;
            Height = 5;
        }
        public Triangle( String colour, double triangleBase, double height ):base(colour)
        {
            Base = triangleBase;
            Height = height;
        }
    }
}
