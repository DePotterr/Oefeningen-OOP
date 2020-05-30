using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSysteem.Klassen;
namespace BankSysteem.Exceptions
{
    class AfbetalingException : Exception
    {
        public Klant Klant { get; set; }
        public AfbetalingException(Klant klant) : base($"Het aangevraagde afbetalingsbedrag voor {klant.Naam} is AFGEKEURD wegens te hoog afbetalingsbedrag. ")
        {
            Klant = klant;
        }
    }
}
