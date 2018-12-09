using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models_and_Functions.Models;
using System.Collections.Generic;
using static System.Math;

namespace Tests.Functions
{
    [TestClass]
    public class Perimeter
    {
        [TestMethod]
        public void QuadratPerimeter()
        {
            Figure testRectangle = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(4, 0));
            edges.Add(new Point(4, 4));
            edges.Add(new Point(0, 4));
            testRectangle.Edges = edges;
            double expected = 16;
            Assert.AreEqual(expected, testRectangle.Perimeter);
        }
        [TestMethod]
        public void SimpleRectanglePerimeter()
        {
            Figure testRectangle = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(6, 0));
            edges.Add(new Point(6, 4));
            edges.Add(new Point(0, 4));
            testRectangle.Edges = edges;
            double expected = 20;
            Assert.AreEqual(expected, testRectangle.Perimeter);
        }
        [TestMethod]
        public void DiagonalRectanglePerimeter()
        {
            Figure testRectangle = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(4, 3));
            edges.Add(new Point(1, 7));
            edges.Add(new Point(-3, 4));
            testRectangle.Edges = edges;
            double expected = 20;
            Assert.AreEqual(expected, testRectangle.Perimeter);
        }
        [TestMethod]
        public void PentagonPerimeter()
        {
            Figure testPentagon = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(4, 0));
            edges.Add(new Point(6, 3));
            edges.Add(new Point(2, 5));
            edges.Add(new Point(-2, 3));
            testPentagon.Edges = edges;
            double expected = 20.15537446092;
            Assert.AreEqual(Round(expected, 4), Round(testPentagon.Perimeter, 4));
        }
    }
}
