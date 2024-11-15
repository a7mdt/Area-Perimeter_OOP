using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapesOPP
{
    internal abstract class Shape
    {
        public double width;
        public double length;

        public abstract double calcArea();
        public abstract double calcPerimeter();
    }
}
