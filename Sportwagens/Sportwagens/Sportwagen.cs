using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportwagens
{
    class Sportwagen : Wagen
    {
        const double VERMEERDERING_BRANDSTOFVERBRUIK = 1.2;
        public double PK { get; set; }
        public int AantalVitessen { get; set; }

        public Sportwagen(Merken merk, Types type, int kmTeller, DateTime inGebruikDatum, string nummerplaat, int pk, int aantalVitessen) : base(merk, type, kmTeller, inGebruikDatum, nummerplaat)
        {
            this.PK = pk;
            this.AantalVitessen = aantalVitessen;
        }

        public override double BerekenBrandstofverbruik(int aantalJaar)
        {
            double resultaat = base.BerekenBrandstofverbruik(aantalJaar);

            if(this.AantalVitessen >= 6)
            {
                resultaat *= VERMEERDERING_BRANDSTOFVERBRUIK;
            }

            return resultaat;
        }

        public override string ToString()
        {
            return "Sportwagen: " + base.ToString() + "\n\tPK: " + this.PK + "\n\tAantalVitessen: " + this.AantalVitessen;
        }
    }
}
