using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stofwinkel
{
    class Stretchstoffen : Stof
    {
        public double Stretchpercentage { get; set; }
        public bool InDroogkast { get; set; }

        public Stretchstoffen(string naam, string designLabel, double prijsPerMeter, double krimpPercentage, Kwaliteitlabels kwaliteitlabel,double stretchpercentage, bool inDroogkast) : base(naam, designLabel, prijsPerMeter, krimpPercentage, kwaliteitlabel)
        {
            Stretchpercentage = stretchpercentage;
            InDroogkast = inDroogkast;
        }
        public override string ToString()
        {
            string aanduiding = "Mag niet in droogkast";
            if (InDroogkast)
            {
                aanduiding = "Mag wel in droogkast";
            }
            return base.ToString() + $" Stretchpercentage: {Stretchpercentage} Aanduiding: {aanduiding}";
        }
    }
}
