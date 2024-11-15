using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapesOPP
{
    internal class Circle: Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double calcArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double calcPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
