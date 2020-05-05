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
            base.Ticket += $" {GetTextBio(IsBio)}";
        }
        public string Scheuren()
        {
            return "Scheuren";
        }
        private string GetTextBio(bool bio)
        {
            string tekst = "Stof is niet Bio";
            if (bio)
            {
                tekst = "Stof is Bio";
            }
            return tekst;
        }
        public override string ToString()
        {
            return base.ToString() + " aanduiding bio: " + GetTextBio(IsBio);
        }
    }
}
