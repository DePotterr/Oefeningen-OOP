using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobbelspel
{
    class Dobbelsteen
    {
        public static Random random = new Random();
        private int zijde;

        public int Zijde
        {
            get { return zijde; }
            set
            {
                if(value >= 1 || value <= 6)
                {
                    zijde = value;
                }
                else
                {
                    zijde = 1;
                }
            }
        }
        public Dobbelsteen()
        {
            Gooi();
        }

        public void Gooi()
        {
            this.Zijde = random.Next(1, 6 + 1);
        }

        public override string ToString()
        {
            return "Zijde: " + this.Zijde;
        }
    }
}
