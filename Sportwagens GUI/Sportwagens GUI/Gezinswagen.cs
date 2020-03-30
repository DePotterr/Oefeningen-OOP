using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportwagens_GUI
{
    class Gezinswagen : Wagen
    {
        const double VERMEERDERING_BRANDSTOFVERBUIK = 1.10;
        public int Zitplaatsen { get; set; }
        public double Koffervolume { get; set; }

        public Gezinswagen(Merken merk, Types type, int kmTeller, DateTime inGebruikDatum, string nummerplaat, int zitplaatsen, int koffervolume) : base(merk, type, kmTeller, inGebruikDatum, nummerplaat)
        {
            this.Zitplaatsen = zitplaatsen;
            this.Koffervolume = koffervolume;
        }

        public override double BerekenBrandstofverbruik(int aantalJaar)
        {
            double resultaat = base.BerekenBrandstofverbruik(aantalJaar);

            if (this.Zitplaatsen >= 7)
            {
                resultaat *= VERMEERDERING_BRANDSTOFVERBUIK;
            }

            return resultaat;
        }

        public override string ToString()
        {
            return "Gezinswagen: " + base.ToString() + " Zitplaatsen: " + this.Zitplaatsen + " Koffervolume: " + this.Koffervolume;
        }
    }
}
