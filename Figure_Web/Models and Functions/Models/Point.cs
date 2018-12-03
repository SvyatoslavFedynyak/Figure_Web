using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_and_Functions.Models
{
    public class Point
    {
        // FIELDS
        internal int id;
        internal double x;
        internal double y;
        internal Figure owner;

        // CONSTRUCTORS
        public Point() { }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //PROPERTIES
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
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Figure Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

    }
}
