using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaShapeLib
{
    public class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(string figureName, double a, double b, double c) : base(figureName)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Одна или несколько сторон заданы неверно");
            if (a > (b + c) || b > (c + a) || c > (a + b))
                throw new ArgumentException("Сумма двух сторон не может превышать длину третьей");

            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override double CalcArea()
        {
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2) ||
                Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2) ||
                Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
        }
    }
}
