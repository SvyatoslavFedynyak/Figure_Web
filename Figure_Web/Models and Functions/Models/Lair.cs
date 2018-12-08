using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_and_Functions.Models
{
    public class Lair
    {
        // FIELDS
        internal int id;
        internal List<Figure> figures;
        internal int level;
        internal bool visible;

        // CONSTRUCTORS
        public Lair()
        {
            figures = new List<Figure>();
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
        public List<Figure> Figures
        {
            get
            {
                return figures;
            }
            set
            {
                figures = value;
            }
        }
        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                visible = value;
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
        public string Name
        {
            get
            {
                return ToString();
            }
        }

        // METHODS
        public void Add(Figure target)
        {
            figures.Add(target);
        }
        public override string ToString()
        {
            return string.Format($"Lair {level}");
        }

    }
}
