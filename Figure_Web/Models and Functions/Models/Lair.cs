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

        // CONSTRUCTORS
        public Lair() { }

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

        // METHODS
        public void Add(Figure target)
        {
            figures.Add(target);
        }

    }
}
