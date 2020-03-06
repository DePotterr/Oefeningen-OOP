using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    class Acteur
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public Acteur(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

        public override string ToString()
        {
            return "Voornaam: " + this.Voornaam + "\nAchternaam: " + this.Achternaam;
        }
    }
}
