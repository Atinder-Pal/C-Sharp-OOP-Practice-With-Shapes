using System;
using Shapes_Practice.Shapes;

namespace Shapes_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle myCircle = new Circle("red", 3.2);
            //Console.WriteLine( myCircle.Area );
            //Console.WriteLine(myCircle.Perimeter);

            //Rectangle myRectangle = new Rectangle("blue", 2, 3);
            //Console.WriteLine(myRectangle.Area);
            //Console.WriteLine(myRectangle.Perimeter);

            //Triangle myTriangle = new Triangle("orange", 4, 5);
            //Console.WriteLine(myTriangle.Area);
            //Console.WriteLine(myTriangle.Perimeter);

            //Rectangle yourRectangle = new Rectangle();
            //Console.WriteLine(yourRectangle.Area);
            //Console.WriteLine(yourRectangle.Perimeter);

            //Illustrating Encapsulation
            Drawing myDrawing = new Drawing();
            myDrawing.Draw(new Rectangle());
            myDrawing.Draw(new Circle());
            myDrawing.Draw(new Triangle());           
            Console.WriteLine(myDrawing.ToString());            
        }
    }
}
