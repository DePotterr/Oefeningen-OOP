using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stofwinkel
{
    class Katoenenstoffen : Stof
    {
        public bool IsBio { get; set; }
        public Katoenenstoffen(string naam, string designLabel, double prijsPerMeter, double krimpPercentage, Kwaliteitlabels kwaliteitlabel, bool isBio) : base(naam, designLabel, prijsPerMeter, krimpPercentage, kwaliteitlabel)
        {
            IsBio = isBio;
        }
    }
}
