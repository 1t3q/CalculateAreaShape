using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaShapeLib
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(string figureName, double radius) : base(figureName)
        {
            if (radius < 0.0)
                throw new ArgumentException("Задан неверный радиус");

            this.Radius = radius;
        }

        public override double CalcArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
