using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    public class Circle : Shape
    {
        double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
