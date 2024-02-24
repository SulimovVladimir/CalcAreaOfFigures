using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaOfFigures.Enum
{
    public class SimpleFigureFactory
    {
        public IFigure Order(FigureType figureType, params double[] value)
        {
            double[] parameter = value;
            if (parameter.Length!=0)
            {
                for(int i=0; i< parameter.Length;i++)
                {
                    if (parameter[i]<0) parameter[i] = Math.Abs(parameter[i]);
                }
            }

            switch (figureType) 
            {
                case FigureType.Circle:
                    {
                        if (parameter.Length!=0) return new Circle(parameter[0]);
                        else return new Circle(1);
                    }
                case FigureType.Triangle:
                    {
                        if (parameter.Length != 0)
                        {
                            if (parameter.Length >= 3) return new Triangle(parameter[0], parameter[1], parameter[2]);
                            if (parameter.Length == 2) return new Triangle(parameter[0], parameter[1], 1);
                            if (parameter.Length == 1) return new Triangle(parameter[0], 1, 1);
                        }
                        return new Triangle(1, 1, 1);
                    }
                    
                default:
                    return new UndefinedFigure(parameter);
            }
        }
    }
}
