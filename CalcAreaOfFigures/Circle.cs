namespace CalcAreaOfFigures
{
    internal class Circle : IFigure
    {
        double radius;

        public Circle(double radius) 
        { 
            this.radius = radius; 
        }

        public double CalcArea() 
        {
            return Math.Round((Math.PI)*Math.Pow(radius, 2),2);
        }
    }
}
