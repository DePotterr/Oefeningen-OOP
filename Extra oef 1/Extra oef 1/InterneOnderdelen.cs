using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_oef_1
{
    class InterneOnderdelen : Product
    {
        public const double EXTRAGARANTIE_PERCENTAGE_INTERNE_ONDERDELEN = 0.15;
        public string Afmetingen { get; set; }

        public InterneOnderdelen(string naam, double prijs, int voorraadProduct, bool extraGarantie, string afmetingen) : base(naam, prijs, voorraadProduct, extraGarantie)
        {
            Afmetingen = afmetingen;
        }
        public override double ExtraBetalenBijPrijs()
        {
            if (ExtraGarantie)
            {
                return Prijs * EXTRAGARANTIE_PERCENTAGE_INTERNE_ONDERDELEN;
            }
            else
                return 0;
        }
        public override string ToString()
        {
            return base.ToString() + " Afmetingen: " + Afmetingen; 
        }
    }
}
