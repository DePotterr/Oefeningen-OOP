using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_oef_1
{
    class KlantBestaatAlException : Exception
    {
        public Klant Klant { get; set; }
        public KlantBestaatAlException(Klant klant) : base("DEZE KLANT BESTAAT AL: " + Environment.NewLine + klant)
        {
            this.Klant = klant;
        }
    }
}
