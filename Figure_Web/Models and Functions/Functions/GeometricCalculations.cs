using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models_and_Functions.Models;
using static System.Math;

namespace Models_and_Functions.Functions
{
    public static class GeometricCalculations
    {
        public static double DistanceBetweenPoints(Point first, Point second)
        {
            return Sqrt(Pow(Abs(first.X - second.X), 2) + Pow(Abs(first.Y - second.Y), 2));
        }
        public static void CalculateSquare(Figure target)
        {
            double res = 0;
            res += target.edges[0].x * (target.edges[1].y - target.edges[target.edges.Count - 1].y);
            for (int i = 1; i < target.edges.Count - 1; i++)
            {
                res += target.edges[i].x * (target.edges[i + 1].y - target.edges[i - 1].y);
            }
            res += target.edges[target.edges.Count - 1].x * (target.edges[0].y - target.edges[target.edges.Count - 2].y);
            res /= 2;
            res = Abs(res);
            target.square = res; 
        }
        public static bool IsPointOnFigure(Point point, Figure figure)
        {
            int triangleCount = figure.edges.Count;
            Figure[] triangles = new Figure[triangleCount];
            for (int i = 0; i < triangleCount - 1; i++)
            {
                triangles[i] = new Figure();
                triangles[i].edges.Add(figure.edges[i]);
                triangles[i].edges.Add(figure.edges[i + 1]);
                triangles[i].edges.Add(point);
            }
            triangles[triangleCount - 1] = new Figure();
            triangles[triangleCount - 1].edges.Add(figure.edges[triangleCount - 1]);
            triangles[triangleCount - 1].edges.Add(figure.edges[0]);
            triangles[triangleCount - 1].edges.Add(point);

            double trianglesSum = 0;
            for (int i = 0; i < triangleCount; i++)
            {
                trianglesSum += triangles[i].Square;
            }
            return trianglesSum == figure.Square;
        }
    }
}
