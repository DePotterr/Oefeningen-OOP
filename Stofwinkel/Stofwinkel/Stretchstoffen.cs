using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stofwinkel
{
    class Stretchstoffen : Stof
    {
        string ticket;
        public double Stretchpercentage { get; set; }
        public bool InDroogkast { get; set; }

        public Stretchstoffen(string naam, string designLabel, double prijsPerMeter, double krimpPercentage, Kwaliteitlabels kwaliteitlabel,double stretchpercentage, bool inDroogkast) : base(naam, designLabel, prijsPerMeter, krimpPercentage, kwaliteitlabel)
        {
            InDroogkast = inDroogkast;
            base.Ticket += $" {stretchpercentage} {Aanduiding()}";
        }
        public string Knippen()
        {
            return "Knippen";
        }
        private string Aanduiding()
        {
            string aanduiding = "Mag niet in droogkast";
            if (InDroogkast)
            {
                aanduiding = "Mag wel in droogkast";
            }
            return aanduiding;
        }
        public override string ToString()
        {

            return base.ToString();
        }
    }
}
