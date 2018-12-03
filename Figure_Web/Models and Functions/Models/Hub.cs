using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_and_Functions.Models
{
    public class Hub
    {
        // FIELDS

        internal List<Lair> lairs;
        internal int xSize;
        internal int ySize;

        // CONSTRUCTORS

        public Hub()
        {
            lairs = new List<Lair>();
        }
        public Hub(int xSize, int ySize)
        {
            lairs = new List<Lair>();
            this.xSize = xSize;
            this.ySize = ySize;
        }

        // PROPERTIES

        public List<Lair> Lairs
        {
            get
            {
                return lairs;
            }
            set
            {
                lairs = value;
            }
        }
        public int XSize
        {
            get
            {
                return xSize;
            }
            set
            {
                xSize = value;
            }
        }
        public int YSize
        {
            get
            {
                return ySize;
            }
            set
            {
                ySize = value;
            }
        }

        // METHODS
        #region Public

        public void AddLair()
        {
            lairs.Add(new Lair());
            lairs.Last().level = lairs.Count - 1;
        }
        public void InsertLair(int pos)
        {
            lairs.Insert(pos, new Lair() { level = pos });
            syncroniseLevels();
        }
        public bool RemoveLastLair()
        {
            if (lairs.Count != 0)
            {
                lairs.RemoveAt(lairs.Count - 1);
                return true;
            }
            return false;
        }
        public void RemoveLairAt(int pos)
        {
            lairs.RemoveAt(pos);
            syncroniseLevels();
        }
        public bool RemoveLair(Lair target)
        {
            bool res = lairs.Remove(target);
            syncroniseLevels();
            return res;
        }

        #endregion

        #region Private

        private void syncroniseLevels()
        {
            for (int i = 0; i < lairs.Count; i++)
            {
                lairs[i].level = i;
            }
        } 

        #endregion

        // OPERATORS AND INDEXERS

        public Lair this[int index]
        {
            get
            {
                return lairs[index];
            }
            set
            {
                lairs[index] = value;
            }
        }
    }
}
