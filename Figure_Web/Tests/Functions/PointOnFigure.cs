using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models_and_Functions.Models;
using Models_and_Functions.Functions;
using static System.Math;
using System.Collections.Generic;

namespace Tests.Functions
{
    [TestClass]
    public class PointOnFigure
    {
        [TestMethod]
        public void PointOnTriangle()
        {
            Figure testFigure = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(4, 0));
            edges.Add(new Point(2, 4));
            testFigure.Edges = edges;
            Point testPoint1 = new Point(2, 3);
            Assert.IsTrue(GeometricCalculations.IsPointOnFigure(testPoint1, testFigure));
            Point testPoint2 = new Point(1, 1);
            Assert.IsTrue(GeometricCalculations.IsPointOnFigure(testPoint2, testFigure));
            Point testPoint3 = new Point(3, 1);
            Assert.IsTrue(GeometricCalculations.IsPointOnFigure(testPoint3, testFigure));
            Point testPoint4 = new Point(1, 3);
            Assert.IsFalse(GeometricCalculations.IsPointOnFigure(testPoint4, testFigure));
            Point testPoint5 = new Point(3, 3);
            Assert.IsFalse(GeometricCalculations.IsPointOnFigure(testPoint5, testFigure));
        }
        [TestMethod]
        public void PointOnRectangle()
        {
            Figure testFigure = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(6, 0));
            edges.Add(new Point(6, 4));
            edges.Add(new Point(0, 4));
            testFigure.Edges = edges;
            Point testPoint1 = new Point(2, 3);
            Assert.IsTrue(GeometricCalculations.IsPointOnFigure(testPoint1, testFigure));
            Point testPoint2 = new Point(1, 1);
            Assert.IsTrue(GeometricCalculations.IsPointOnFigure(testPoint2, testFigure));
            Point testPoint3 = new Point(5.999, 1);
            Assert.IsTrue(GeometricCalculations.IsPointOnFigure(testPoint3, testFigure));
            Point testPoint4 = new Point(0.01, 0.01);
            Assert.IsTrue(GeometricCalculations.IsPointOnFigure(testPoint4, testFigure));
            Point testPoint5 = new Point(6.000001, 3);
            Assert.IsFalse(GeometricCalculations.IsPointOnFigure(testPoint5, testFigure));
            Point testPoint6 = new Point(6.000001, 4.0000001);
            Assert.IsFalse(GeometricCalculations.IsPointOnFigure(testPoint6, testFigure));
            Point testPoint7 = new Point(100, 200);
            Assert.IsFalse(GeometricCalculations.IsPointOnFigure(testPoint7, testFigure));
        }
    }
}
