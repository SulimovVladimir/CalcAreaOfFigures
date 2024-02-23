using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaOfFigures
{
    public class Triangle
    {
        public double CalcArea(double side1, double side2, double side3)
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }
    }
}
