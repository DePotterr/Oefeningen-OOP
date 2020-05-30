using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSysteem.Klassen;

namespace BankSysteem.Exceptions
{
    class KredietWaardigException : Exception
    {
        public Klant Klant { get; set; }
        public KredietWaardigException(Klant klant) : base($"Het aangevraagde afbetalingsbedrag voor {klant.Naam} is AFGEKEURD. {klant.Naam} is niet kredietwaardig.")
        {
            Klant = klant;
        }
    }
}
