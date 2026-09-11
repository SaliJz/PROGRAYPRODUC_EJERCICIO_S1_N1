using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_FigureAreas
{
    public class Triangle : Figure
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double GetArea()
        {
            return (baseLength * height) / 2;
        }
    }
}