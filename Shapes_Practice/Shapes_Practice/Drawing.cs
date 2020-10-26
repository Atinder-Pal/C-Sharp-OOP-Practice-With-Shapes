using System;
using System.Collections.Generic;
using System.Text;
using Shapes_Practice.Shapes;

namespace Shapes_Practice
{
    class Drawing
    {
        private List<Shape> _shapes;
        //Illustrating Polymorphism
        private List<Shape> Shapes 
        { 
            get
            {
                return _shapes;
            }
            set
            {
                _shapes = value;
            }
        }
        public double SpaceCovered { get; }
        public double LinesDrawn { get; }

        //Methods
        public void Draw( Shape shape )
        {
            Shapes.Add(shape);
        }
        public override string ToString()
        {
            return $"A drawing consisting of {Shapes.Count} shapes.";
        }
        //Default Constructor
        public Drawing()
        {
            Shapes = new List<Shape>();
        }
    }
}
