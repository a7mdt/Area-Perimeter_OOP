using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapesOPP
{
    internal class Square: Shape
    {
        public Square(double sqLength) 
        { 
            length = sqLength;
        }

        public override double calcArea()
        {
            return Math.Pow(length, 2);
        }

        public override double calcPerimeter()
        {
            return length * 4;
        }
    }
}
