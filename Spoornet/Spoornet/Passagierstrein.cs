using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoornet
{
    class Passagierstrein : Trein
    {
        public int Max_AantalPassagiers { get; set; }

        public Passagierstrein(string naam,Bestemmingen bestemmingen, DateTime tijdstip, int maxAantalPassagiers) : base(naam, bestemmingen, tijdstip)
        {
            Max_AantalPassagiers = maxAantalPassagiers;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
