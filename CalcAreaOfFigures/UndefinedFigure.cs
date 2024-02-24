using CalcAreaOfFigures.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaOfFigures
{
    internal class UndefinedFigure : IFigure
    {
        double[] parameter; 
        public UndefinedFigure(double[] parameter) 
        {
            this.parameter = parameter;
        }

        public double CalcArea()
        {
            if(parameter.Length==0) return 0.0;

            var factory = new SimpleFigureFactory();
            switch (parameter.Length) 
            {
                case 1:
                    {
                        var figure = factory.Order(FigureType.Circle, parameter[0]);
                        return figure.CalcArea();
                    }
                case 2:
                    {
                        //можно добавить реализацию прямоугольника
                        return 0.0;
                    }
                case 3:
                    {
                        var figure = factory.Order(FigureType.Triangle, parameter[0], parameter[1], parameter[2]);
                        return figure.CalcArea();
                    }
                case 4:
                    {
                        //можно добавить реализацию трапеции
                        return 0.0;
                    }
                    default: return 0.0;
            }
        }
    }
}
