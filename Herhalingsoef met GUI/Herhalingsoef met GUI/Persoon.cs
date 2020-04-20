using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_met_GUI
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }

        public Persoon(string voornaam, string naam)
        {
            this.Voornaam = voornaam;
            this.Naam = naam;
        }

        public override string ToString()
        {
            return this.Voornaam + " " + this.Naam;
        }
    }
}
