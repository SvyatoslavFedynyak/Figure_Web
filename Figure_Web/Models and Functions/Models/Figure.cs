using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
                return perimeter;
            }
            set
            {
                perimeter = value;
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
            set
            {
                square = value;
            }
        }

    }
}
