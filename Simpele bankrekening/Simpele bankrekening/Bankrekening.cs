using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpele_bankrekening
{
    class Bankrekening
    {
        public string NaamHouder { get; set; }
        public decimal Rekening { get; set; }
        public Bankrekening(string naamHouder, decimal rekening)
        {
            this.NaamHouder = naamHouder;
            this.Rekening = rekening;
        }

        public void Toevoegen(decimal bedrag)
        {
            this.Rekening += bedrag;
        }

        public void Afnemen(decimal bedrag)
        {
            this.Rekening -= bedrag;
        }

        public override string ToString()
        {
            return "Naam: " + this.NaamHouder + " Rekening: " + this.Rekening;
        }
    }
}
