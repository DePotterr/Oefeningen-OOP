using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_oef_1
{
    class ExterneAccessoires : Product
    {
        public const double EXTRAGARANTIE_PERCENTAGE_EXTERNE_ACCESSOIRES = 0.10;

        public bool IsDraadloos { get; set; }
        public ExterneAccessoires(string naam, double prijs, int voorraadProduct,bool extraGarantie, bool isDraadloos) : base(naam, prijs, voorraadProduct, extraGarantie)
        {
            IsDraadloos = isDraadloos;
        }
        public override double ExtraBetalenBijPrijs()
        {
            if (ExtraGarantie)
            {
                return Prijs * EXTRAGARANTIE_PERCENTAGE_EXTERNE_ACCESSOIRES;
            }
            else
                return 0;
        }
        public override string ToString()
        {
            string draadloos = "Niet draadloos";
            if (IsDraadloos)
            {
                draadloos = "Draadloos";
            }
            return base.ToString() + " " + draadloos;
        }
    }
}
