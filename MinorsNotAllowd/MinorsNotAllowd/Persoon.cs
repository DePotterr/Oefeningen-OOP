using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefPersoon
{
    class Persoon
    {
        public enum Geslachten { Man, Vrouw}
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        private DateTime geboorteDatum;

        public DateTime Geboortedatum
        {
            get { return geboorteDatum; }
            set
            {
                if(value <= DateTime.Today.AddYears(-18))
                {
                    geboorteDatum = value;
                }
                else
                {
                    Exception ex = new Exception("Je bent nog te jong");
                    throw ex;
                }
            }
        }

        public Geslachten Geslacht { get; set; }

        public Persoon(string voornaam, string naam, DateTime geboortedatum, Geslachten geslacht)
        {
            this.Voornaam = voornaam;
            this.Naam = naam;
            this.Geboortedatum = geboortedatum;
            this.Geslacht = geslacht;
        }

        public Persoon(string voornaam, string naam) : this(voornaam, naam, new DateTime(2000, 1, 1), Geslachten.Vrouw)
        {}
        public int Berekenleeftijd(DateTime geboortedatum)
        {
            int leeftijd = DateTime.Today.Year - this.Geboortedatum.Year;
            DateTime Vergelijkinggeboortedatum = new DateTime(DateTime.Today.Year, geboortedatum.Month, geboortedatum.Day);
            if (Vergelijkinggeboortedatum > DateTime.Today)
            {
                leeftijd--;
            }
            return leeftijd;
        }
        public int Leeftijd()
        {
            return Berekenleeftijd(this.Geboortedatum);
        }

        public override string ToString()
        {
            return "Persoon:\n\tVoornaam: " + this.Voornaam + "\n\tNaam: " + "\n\tGeslacht: " + this.Geslacht + this.Naam + "\n\tLeeftijd: " + this.Leeftijd() + " jaar oud.";
        }
    }
}
