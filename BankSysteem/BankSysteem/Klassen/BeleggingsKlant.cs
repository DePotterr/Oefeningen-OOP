using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSysteem.Klassen;
using BankSysteem.Exceptions;

namespace BankSysteem.Klassen
{
    class BeleggingsKlant : Klant
    {
        public BeleggingsKlant(string naam, string adres, string telefoonnumer, double salaris) : base(naam, adres, telefoonnumer, true, salaris)
        {
        }
        public override double MaxAfbetalingsBedrag()
        {
            return CheckSalaris() / 2;
        }
        public double MaxBeleggen()
        {
            if (this.KredietWaardig)
            {
                return CheckSalaris() / 4;
            }
            else
            {
                throw new KredietWaardigException(this);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
