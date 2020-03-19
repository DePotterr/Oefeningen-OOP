using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival
{
    class Artiest : Evenement
    {
        public enum StijlenMuziek { RNB, Dance, Rock, DNB}
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public StijlenMuziek StijlMuziek { get; set; }

        public Artiest(string voornaam, string achternaam, StijlenMuziek stijlMuziek, DateTime datumEvenement, string plaatsEvenement, string naamEvenement) : base(datumEvenement, plaatsEvenement, naamEvenement, 500)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            StijlMuziek = stijlMuziek;
        }

        public override string ToString()
        {
            return "Naam: " + this.Voornaam + "\nAchternaam: " + this.Achternaam + "\nStijl muziek: " + this.StijlMuziek;
        }
    }
}
