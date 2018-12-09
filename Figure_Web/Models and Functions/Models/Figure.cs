using System;
using System.Collections.Generic;
using System.Drawing;
using static System.Math;

namespace Models_and_Functions.Models
{
    public class Figure
    {
        // FIELDS
        internal int id;
        internal List<Point> edges;
        internal Figure[] subfigures;
        internal Figure upfigure;
        internal double perimeter;
        internal double square;
        internal Color color;

        // CONSTRUCTORS
        public Figure()
        {
            edges = new List<Point>();
        }

        // PROPERTIES
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public List<Point> Edges
        {
            get
            {
                return edges;
            }
            set
            {
                edges = value;
                for (int i = 0; i < edges.Count; i++)
                {
                    edges[i].owner = this;
                }
            }
        }
        public Figure[] Subfigures
        {
            get
            {
                return subfigures;
            }
            set
            {
                subfigures = value;
            }
        }
        public Figure Upfigure
        {
            get
            {
                return upfigure;
            }
            set
            {
                upfigure = value;
            }
        }
        public double Perimeter
        {
            get
            {
                if (perimeter == 0)
                {
                    perimeter = 0;
                    for (int i = 0; i < edges.Count - 1; i++)
                    {
                        perimeter += Functions.GeometricCalculations.DistanceBetweenPoints(edges[i], edges[i + 1]);
                    }
                    perimeter += Functions.GeometricCalculations.DistanceBetweenPoints(edges[edges.Count - 1], edges[0]);
                }
                return perimeter;
            }
        }
        public double Square
        {
            get
            {
                if (square == 0)
                {
                    Functions.GeometricCalculations.CalculateSquare(this);
                }
                return square;
            }
        }

        // METHODS 
        public override string ToString()
        {
            return string.Format($"{edges.Count}-edges pentagon with ARGB({color.ToString()}), square: {Square} and perimeter: {Round(Perimeter, 3)}");
        }

    }
}
