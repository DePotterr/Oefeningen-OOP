using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_met_GUI
{
    class Activiteit
    {
        private const int KOSTPRIJS = 5;
        public enum Soorten { Handwerk, Geheugentraining, Beweging}

        public Soorten Soort { get; set; }
        public DateTime DatumActiviteit { get; set; }
        public int Kostprijs { get; private set; }

        public Activiteit(Soorten soort, DateTime datumActiviteit)
        {

            this.Soort = soort;
            this.DatumActiviteit = datumActiviteit;
            Kostprijs = KOSTPRIJS;
        }

        public override string ToString()
        {
            return "Soort:" + this.Soort + " Datum activiteit: " + this.DatumActiviteit;
        }
    }
}
