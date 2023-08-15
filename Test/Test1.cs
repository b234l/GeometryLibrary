using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLibrary.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod] // Проверка вычисления площади круга
        public void Circle_CalculateArea_ReturnsCorrectArea()
        {
            Circle circle = new Circle();
            circle.Radius = 5;
            double area = circle.CalculateArea();
            Assert.AreEqual(78.53981633974483, area);
        }

        [TestMethod] // Проверка вычисления площади треугольника
        public void Triangle_CalculateArea_ReturnsCorrectArea()
        {
            Triangle triangle = new Triangle();
            triangle.Side1 = 3;
            triangle.Side2 = 4;
            triangle.Side3 = 5;
            double area = triangle.CalculateArea();
            Assert.AreEqual(6, area);
        }

        [TestMethod] // Проверка на прямоугольность треугольника когда True
        public void Triangle_IsRightTriangle_ReturnsTrue()
        {
            Triangle triangle = new Triangle();
            triangle.Side1 = 3;
            triangle.Side2 = 4;
            triangle.Side3 = 5;
            bool isRightTriangle = triangle.IsRightTriangle();
            Assert.IsTrue(isRightTriangle);
        }

        [TestMethod] // Проверка на прямоугольность треугольника когда False
        public void Triangle_IsRightTriangle_ReturnsFalse()
        {
            Triangle triangle = new Triangle();
            triangle.Side1 = 2;
            triangle.Side2 = 4;
            triangle.Side3 = 5;
            bool isRightTriangle = triangle.IsRightTriangle();
            Assert.IsFalse(isRightTriangle);
        }
    }
}
