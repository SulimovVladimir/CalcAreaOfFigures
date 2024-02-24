using CalcAreaOfFigures.Enum;

namespace CalcAreaOfFiguresTest
{
    public class CalcAreaOfFigures_Test
    {
        SimpleFigureFactory factory = new SimpleFigureFactory();

        [Fact]
        public void CalcAreaCircleTest()
        {
            var figure = factory.Order(FigureType.Circle, 1);
            double expectedArea = 3.14;

            double resultArea = figure.CalcArea();

            Assert.True(expectedArea == resultArea);
        }

        [Fact]
        public void CalcAreaTriangleTest()
        {
            var figure = factory.Order(FigureType.Triangle, 1,1,1);
            double expectedArea = 0.43;

            double resultArea = figure.CalcArea();

            Assert.True(expectedArea == resultArea);
        }

        [Fact]
        public void IsRightTriangleTest()
        {
            var figure1 = factory.Order(FigureType.Triangle, 5, 4, 3);
            var figure2 = factory.Order(FigureType.Triangle, 5, 4, 4);
            bool expectedResult1 = true;
            bool expectedResult2 = false;

            bool result1 = figure1.IsRightTriangle();
            bool result2 = figure2.IsRightTriangle();

            Assert.True(expectedResult1 == result1);
            Assert.True(expectedResult2 == result2);
        }

        [Fact]
        public void CreateTriangleTest()
        {
            var figure1 = factory.Order(FigureType.Triangle);
            var figure2 = factory.Order(FigureType.Triangle, 1);
            var figure3 = factory.Order(FigureType.Triangle, 1, 1);
            var figure4 = factory.Order(FigureType.Triangle, -1, -1, -1);

            double expectedArea = 0.43;

            double resultArea1 = figure1.CalcArea();
            double resultArea2 = figure2.CalcArea();
            double resultArea3 = figure3.CalcArea();
            double resultArea4 = figure4.CalcArea();

            Assert.True(expectedArea == resultArea1 && expectedArea == resultArea2 && expectedArea == resultArea3 && expectedArea == resultArea4);
        }

      
        [Fact]
        public void CreateCircleTest()
        {
            var figure1 = factory.Order(FigureType.Circle);
            var figure2 = factory.Order(FigureType.Circle,-1);
            var figure3 = factory.Order(FigureType.Circle, 1, 1);
            double expectedArea = 3.14;

            double resultArea1 = figure1.CalcArea();
            double resultArea2 = figure2.CalcArea();
            double resultArea3 = figure3.CalcArea();

            Assert.True(expectedArea == resultArea1 && expectedArea == resultArea2 && expectedArea == resultArea3);
        }
    }
}