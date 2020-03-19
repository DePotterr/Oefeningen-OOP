using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival
{
    class Evenement
    {
        public DateTime DatumEvenement { get; set; }
        public string PlaatsEvenement { get; set; }
        public string NaamEvenement { get; set; }
        public double Inkom { get; set; }
        public Evenement(DateTime datum, string plaats, string naam, double inkom)
        {
            DatumEvenement = datum;
            PlaatsEvenement = plaats;
            NaamEvenement = naam;
            this.Inkom = inkom;
        }
        public override string ToString()
        {
            return "Naam: " + this.NaamEvenement + "\nDatum: " + this.DatumEvenement + "\nPlaats: " + this.PlaatsEvenement + "\nInkom: " + this.Inkom;
        }
    }
}
