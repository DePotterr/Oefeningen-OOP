using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    class Dier
    {
        public string Voornaam { get; set; }
        public int Gewicht { get; set; }
        public int GeboorteJaar { get; set; }
        public string Geluid { get; set; }

        public Dier(string voornaam, int gewicht, int geboortejaar)
        {
            this.Voornaam = voornaam;
            this.Gewicht = gewicht;
            this.GeboorteJaar = geboortejaar;
            this.Geluid = "grom grom";
        }

        public virtual int BerekenLeeftijd()
        {
            return DateTime.Today.Year - GeboorteJaar;
        }

        public override string ToString()
        {
            return "\n\tVoornaam: " + this.Voornaam + "\n\tGewicht: " + this.Gewicht + "\n\tGeboortejaar: " + this.GeboorteJaar + "\n\tGeluid: " + this.Geluid;
        }
    }
}
