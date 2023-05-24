using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircleAreaTest
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.GetArea());
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            double s = (a + b + c) / 2;
            Assert.AreEqual(Math.Sqrt(s * (s - a) * (s - b) * (s - c)), triangle.GetArea());
        }

        [TestMethod]
        public void RightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}