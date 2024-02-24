using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaOfFigures
{
    internal class Triangle : IFigure
    {
        double side1, side2, side3;
        public Triangle(double side1, double side2, double side3) 
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double CalcArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Round(Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3)),2) ;
        }

        public bool IsRightTriangle()
        {
            List<double> sides = new List<double> { side1, side2, side3 };
            sides = sides.OrderByDescending(x => x).ToList();
            if (Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2)) return true;
            return false;
        }
    }
}
