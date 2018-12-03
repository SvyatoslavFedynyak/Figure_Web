using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models_and_Functions.Models;
using static System.Math;

namespace Tests.Functions
{
    [TestClass]
    public class Range
    {
        int accuracy = 8;
        [TestMethod]
        public void SimplePointsTest()
        {
            Point first = new Point(3, 4);
            Point second = new Point(7, 11);
            double expected = Sqrt(65);
            Assert.AreEqual(Round(expected, accuracy), Round(Models_and_Functions.Functions.GeometricCalculations.DistanceBetweenPoints(first, second), accuracy));
        }
        [TestMethod]
        public void MinusPointsTest()
        {
            Point first = new Point(-3, 4);
            Point second = new Point(7, -11);
            double expected = Sqrt(325);
            Assert.AreEqual(Round(expected, accuracy), Round(Models_and_Functions.Functions.GeometricCalculations.DistanceBetweenPoints(first, second), accuracy));
        }
    }
}
