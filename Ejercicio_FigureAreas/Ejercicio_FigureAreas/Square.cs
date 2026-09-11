using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_FigureAreas
{
    public class Square : Figure
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }
    }
}