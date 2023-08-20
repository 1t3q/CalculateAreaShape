using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateAreaShapeLib;
using NUnit.Framework;

namespace Figure.Tests
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        public void getCircleArea_Radius10_ShouldReturnArea314()
        {
            //Arrange
            Circle circle = new ("Круг", 10);

            //Act
            double result = circle.CalcArea();

            //Assert
            Assert.AreEqual(314.1592653589793, result);
        }
    }
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void getTriangleArea_A3B4C5_ShouldReturnArea6()
        {
            //Arrange
            Triangle triangle = new ("Треугольник", 3, 1, 3);

            //Act
            double result = triangle.CalcArea();

            //Assert
            Assert.AreEqual(1.479019945774904, result);
        }

        [Test]
        public void checkRightTriangle_A3B4C5_ShoudReturnTrue()
        {
            //Arrange
            Triangle triangle = new("Треугольник", 3, 4, 5);

            //Act
            bool result = triangle.IsRightTriangle();

            //Assert
            Assert.AreEqual(true, result);
        }
    }
    [TestFixture]
    public class FigureTest
    {
        [Test]
        public void getAreaNotKnowTypeFigure_TriangleA3B4C5_ShoudReturn6()
        {
            //Arrange
            Triangle triangle = new("Треугольник", 3, 4, 5);

            //Act
            double result = CalculateAreaShapeLib.Figure.CalcFigure(triangle);

            //Assert
            Assert.AreEqual(6, result);
        }
    }
}
