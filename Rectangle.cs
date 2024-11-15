using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapesOPP
{
    internal class Rectangle: Shape
    {
        public Rectangle(double rectLength, double rectWidth)
        {
            length = rectLength;
            width = rectWidth;
        }

        public override double calcArea()
        {
            return length * width;
        }

        public override double calcPerimeter()
        {
            return 2 * (length + width);
        }
    }
}
