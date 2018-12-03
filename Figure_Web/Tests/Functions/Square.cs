using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models_and_Functions.Models;
using System.Collections.Generic;

namespace Tests.Functions
{
    [TestClass]
    public class Square
    {
        [TestMethod]
        public void QuadratSquare()
        {
            Figure testRectangle = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(4, 0));
            edges.Add(new Point(4, 4));
            edges.Add(new Point(0, 4));
            testRectangle.Edges = edges;
            double expected = 16;
            Assert.AreEqual(expected, testRectangle.Square);
        }
        [TestMethod]
        public void SimpleRectangleSquare()
        {
            Figure testRectangle = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(6, 0));
            edges.Add(new Point(6, 4));
            edges.Add(new Point(0, 4));
            testRectangle.Edges = edges;
            double expected = 24;
            Assert.AreEqual(expected, testRectangle.Square);
        }
        [TestMethod]
        public void DiagonalRectangleSquare()
        {
            Figure testRectangle = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(4, 3));
            edges.Add(new Point(1, 7));
            edges.Add(new Point(-3, 4));
            testRectangle.Edges = edges;
            double expected = 25;
            Assert.AreEqual(expected, testRectangle.Square);
        }
        [TestMethod]
        public void PentagonSquare()
        {
            Figure testPentagon = new Figure();
            List<Point> edges = new List<Point>();
            edges.Add(new Point(0, 0));
            edges.Add(new Point(4, 0));
            edges.Add(new Point(6, 3));
            edges.Add(new Point(2, 5));
            edges.Add(new Point(-2, 3));
            testPentagon.Edges = edges;
            double expected = 26;
            Assert.AreEqual(expected, testPentagon.Square);
        }
    }
}
