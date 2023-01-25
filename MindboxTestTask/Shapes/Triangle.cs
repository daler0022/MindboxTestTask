using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    public class Triangle : Shape
    {
        double side1, side2, side3;

        public Triangle(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public override double GetArea()
        {
            // Формула Герона для вычисления площади треугольника
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public bool IsRightTriangle()
        {
            // Проверка, является ли треугольник прямоугольным с помощью теоремы Пифагора
            double maxSide = Math.Max(side1, Math.Max(side2, side3));
            double sumOfSquaresOfOtherSides = (side1 * side1) + (side2 * side2) + (side3 * side3) - (maxSide * maxSide);
            return Math.Abs(sumOfSquaresOfOtherSides - (maxSide * maxSide)) < 0.0001;
        }
    }
}
