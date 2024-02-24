using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaOfFigures
{
    public interface IFigure
    {
        public double CalcArea();

        public bool IsRightTriangle()
        {
            return false;
        }
    }
}
